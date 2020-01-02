using System;

namespace R.ARC.Util.Logging
{
    public interface IAppLogger<T>: IDisposable
    {
        void Debug(string message);
        void Debug(string message, Exception exception);
        void Info(string message);
        void Info(string message, Exception exception);
        void Error(string message);
        void Error(string message, Exception exception);
        void Critical(string message);
        void Critical(string message, Exception exception);
        void Warning(string message);
        void Warning(string message, Exception exception);
    }
}
