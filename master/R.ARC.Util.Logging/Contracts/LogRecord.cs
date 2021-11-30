using Microsoft.Extensions.Logging;
using System;

namespace R.ARC.Util.Logging.Contracts
{
    /// <summary>
    /// Entity for keeping single log entry data
    /// </summary>
    public class LogRecord
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogRecord"/> class
        /// </summary>
        public LogRecord()
        {
            LogTime = DateTime.Now;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogRecord"/> class
        /// </summary>
        /// <param name="eventId">Event ID</param>
        /// <param name="eventName">Event name</param>
        /// <param name="logLevel">Severity level</param>
        /// <param name="categoryName">Category name</param>
        /// <param name="scope">Logging scope</param>
        /// <param name="message">Log record message</param>
        /// <param name="exception">Caught exception</param>
        public LogRecord(string appName
            , int eventId
            , string eventName
            , LogLevel logLevel
            , string categoryName
            , string scope
            , string message
            , string userName
            , string ipAddress
            , string macAddress
            , string hostName
            , string requestUrl
            , string requestBody
            , Exception exception = null)
        {
            AppName = appName != null ? appName: string.Empty ;
            LogTime = DateTime.UtcNow;
            EventId = eventId;
            EventName = eventName != null ? eventName : string.Empty;
            LogLevel = logLevel;
            Category = categoryName != null ? categoryName : string.Empty;
            Scope = scope != null ? scope : string.Empty;
            Message = message != null ? message : string.Empty;
            Exception = exception;
            UserName = userName != null ? userName : string.Empty;
            IpAddress = ipAddress != null ? ipAddress : string.Empty;
            MacAddress = macAddress != null ? macAddress : string.Empty;
            HostName = hostName != null ? hostName : string.Empty;
            RequestUrl = requestUrl != null ? requestUrl : string.Empty;
            RequestBody = requestBody != null ? requestBody : string.Empty;
        }

        public string AppName { get; set; }

        /// <summary>
        /// Gets the log record time stamp
        /// </summary>
        public DateTime LogTime { get; }

        /// <summary>
        /// Gets or sets the event ID
        /// </summary>
        public int EventId { get; set; }

        /// <summary>
        /// Gets or sets the event name
        /// </summary>
        public string EventName { get; set; }

        /// <summary>
        /// Gets or sets the severity level
        /// </summary>
        public LogLevel LogLevel { get; set; }

        /// <summary>
        /// Gets or sets the category name
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the logging scope
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets the log record message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the caught exception
        /// </summary>
        public Exception Exception { get; set; }


        public string UserName { get; set; }

        public string IpAddress { get; set; }

        public string MacAddress { get; set; }

        public string HostName { get; set; }

        public string RequestUrl { get; set; }

        public string RequestBody { get; set; }
    }
}
