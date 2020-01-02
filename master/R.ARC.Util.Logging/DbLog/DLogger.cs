using Microsoft.Extensions.Logging;
using R.ARC.Util.Logging.Contracts;
using R.ARC.Util.Session;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace R.ARC.Util.Logging.DbLog
{
    public static class ObjectExtensions
    {
        public static T GetPrivateFieldValue<T>(this object value, string fieldName)
        {
            var field = value.GetType().GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.GetField);

            if (field != null)
                return (T)field.GetValue(value);

            return default(T);
        }
    }

    public class DLogger : ILogger
    {
        private readonly ILogWriter _writer;
        private Func<string, LogLevel, bool> _filter;

        public DLogger(string category, Func<string, LogLevel, bool> filter, ILogWriter writer, ILoggerSettings settings)
        {
            _writer = writer;
            _filter = filter;
            Category = category;
            Settings = settings;
        }

        #region Properties

        /// <summary>
        /// Gets the log category
        /// </summary>
        public string Category { get; }

        /// <summary>
        /// Gets or sets the <see cref="ILoggerSettings"/> instance
        /// </summary>
        public ILoggerSettings Settings { get; set; }

        /// <summary>
        /// Gets or sets the delegate used for filtering whether a log record should be discarded
        /// </summary>
        public Func<string, LogLevel, bool> Filter
        {
            get => _filter;
            set
            {
                _filter = value ?? throw new ArgumentNullException(nameof(value));
            }
        }

        #endregion

        #region ILogger Implementation

        public IDisposable BeginScope<TState>(TState state)
        {
            if (state == null)
            {
                throw new ArgumentNullException(nameof(state));
            }

            return LogScope.Push(state.ToString());
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return Filter(Category, logLevel);
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            object[] args = state.GetPrivateFieldValue<object[]>("_values");

            ISessionManager sessionManager = args?.Length > 0 ? args[0] as ISessionManager: null;

            string appName = (args?.Length > 1) ? args[1] as string : "";

            if (sessionManager == null)
                sessionManager = new SessionManager();

            if (!IsEnabled(logLevel))
                return;

            LogRecord log = new LogRecord(appName
                , eventId.Id
                , eventId.Name
                , logLevel
                , Category
                , GetScope()
                , state.ToString()
                , sessionManager.UserName
                , sessionManager.IpAddress
                , sessionManager.MacAddress
                , sessionManager.HostName
                , sessionManager.RequestUrl
                , sessionManager.RequestBody
                , exception);

            if (Settings.BulkWrite)
            {
                LogRecordCache.Add(log);

                if (LogRecordCache.IsFull)
                {
                    LogRecordCache.Flush(_writer);
                }
            }
            else
            {
                _writer.WriteLog(log);
            }
        }

        #endregion

        #region Helpers

        private string GetScope()
        {
            if (!Settings.IncludeScopes)
                return null;

            LogScope current = LogScope.Current;
            StringBuilder scope = new StringBuilder();

            while (current != null)
            {
                scope.Append(current);

                if (current.Parent != null)
                {
                    scope.AppendLine();
                    scope.Append("=> ");
                }

                current = current.Parent;
            }

            return scope.ToString();
        }

        #endregion

        #region LogScope
        internal class LogScope
        {
            private static AsyncLocal<LogScope> _value = new AsyncLocal<LogScope>();
            private string _scope { get; }

            public static LogScope Current
            {
                get => _value.Value;
                set => _value.Value = value;
            }

            public LogScope Parent { get; private set; }

            public LogScope(string scope)
            {
                _scope = scope;
            }

            public static IDisposable Push(string scope)
            {
                LogScope temp = Current;
                Current = new LogScope(scope)
                {
                    Parent = temp
                };

                return new DisposableScope();
            }

            public override string ToString()
            {
                return _scope;
            }

            private class DisposableScope : IDisposable
            {
                public void Dispose()
                {
                    Current = Current.Parent;
                }
            }
        }
        #endregion

        #region LogRecordCache

        internal static class LogRecordCache
        {
            private static readonly object _lockObject = new object();
            private static readonly List<LogRecord> _logs;
            private static int _maxCacheSize;
            private static bool _flushingInProgress = false;

            static LogRecordCache()
            {
                _logs = new List<LogRecord>();
            }

            public static bool IsEmpty => _flushingInProgress || _logs.Count == 0;

            public static bool IsFull => !_flushingInProgress && _logs.Count >= _maxCacheSize;

            public static void Add(LogRecord log)
            {
                if (_flushingInProgress)
                {
                    lock (_lockObject)
                    {
                        _logs.Add(log);
                    }
                }
                else
                {
                    _logs.Add(log);
                }
            }

            public static void SetCapacity(int cacheSize)
            {
                _maxCacheSize = cacheSize;
                _logs.Capacity = cacheSize * 2;
            }

            public static void Flush(ILogWriter writer)
            {
                if (!_flushingInProgress)
                {
                    _flushingInProgress = true;
                    Task.Run(() => writer.WriteBulk(_logs, _lockObject, ref _flushingInProgress));
                }
            }
        }
        #endregion
    }
}
