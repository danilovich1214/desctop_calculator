using System;

namespace Framework.TestStackWhite
{
    public abstract class BaseEntity
    {        
        protected static Logger Log = Logger.Instance;

        protected abstract String FormatLogMsg(string message);

        /// <summary>
        /// debug in log
        /// </summary>
        /// <param name="message">message for log</param>
        protected void Debug(String message)
        {
            Log.Debug(FormatLogMsg(message));
        }

        /// <summary>
        /// info in log
        /// </summary>
        /// <param name="message">message for log</param>
        protected void Info(String message)
        {
            Log.Info(FormatLogMsg(message));
        }

        /// <summary>
        /// warn in log
        /// </summary>
        /// <param name="message">message for log</param>
        protected void Warn(String message)
        {
            Log.Warn(FormatLogMsg(message));
        }

        /// <summary>
        /// error in log
        /// </summary>
        /// <param name="message">message for log</param>
        protected void Error(String message)
        {
            Log.Error(FormatLogMsg(message));
        }

        /// <summary>
        /// fatal in log
        /// </summary>
        /// <param name="message">message for log</param>
        protected void Fatal(String message)
        {
            Log.Fail(FormatLogMsg(message));
        }

    }
}
