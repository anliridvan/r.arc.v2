using Microsoft.Extensions.Logging;
using R.ARC.Util.Session;
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace R.ARC.Util.Logging
{
    public class LoggerAdaptor<T> : IAppLogger<T>
    {
        private ILogger<T> _logger { get; }

        private string _appName { get; }

        private ISessionManager _sessionManager { get; }

        public LoggerAdaptor(IServiceProvider serviceProvider)
        {
            _sessionManager = serviceProvider.GetService<ISessionManager>();
            _appName = serviceProvider.GetService<IConfiguration>().GetSection("AppParameters")?.GetValue<string>("AppName");

            var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            _logger = loggerFactory.CreateLogger<T>();
        }

        #region Methods

        public void Debug(string message)
        {
            _logger.LogDebug(message, _sessionManager, _appName);
        }

        public void Debug(string message, Exception exception)
        {
            _logger.LogDebug(exception, message, _sessionManager, _appName);
        }

        public void Info(string message)
        {
            _logger.LogInformation(message, _sessionManager, _appName);
        }

        public void Info(string message, Exception exception)
        {
            _logger.LogInformation(exception, message, _sessionManager, _appName);
        }

        public void Error(string message)
        {
            _logger.LogError(message, _sessionManager, _appName);
        }

        public void Error(string message, Exception exception)
        {
            _logger.LogError(exception, message, _sessionManager, _appName);
        }

        public void Critical(string message)
        {
            _logger.LogCritical(message, _sessionManager, _appName);
        }

        public void Critical(string message, Exception exception)
        {
            _logger.LogCritical(exception, message, _sessionManager, _appName);
        }

        public void Warning(string message)
        {
            _logger.LogWarning(message, _sessionManager, _appName);
        }

        public void Warning(string message, Exception exception)
        {
            _logger.LogWarning(exception, message, _sessionManager, _appName);
        }

        private bool disposed = false;

        public void Dispose()
        {

            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing && _logger != null)
            {
                //  _logger = null;
            }
            disposed = true;
        }

        #endregion
    }
}
