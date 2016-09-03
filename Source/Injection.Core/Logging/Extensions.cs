
namespace Whimsy.Precondition.Injection.Core.Logging
{
    public static class Extensions
    {
        public static void Trace(this ILog log, string message)
        {
            log.Log(LogLevel.Trace, message);
        }

        public static void Debug(this ILog log, string message)
        {
            log.Log(LogLevel.Debug, message);
        }

        public static void Info(this ILog log, string message)
        {
            log.Log(LogLevel.Info, message);
        }

        public static void Warn(this ILog log, string message)
        {
            log.Log(LogLevel.Warn, message);
        }

        public static void Error(this ILog log, string message)
        {
            log.Log(LogLevel.Error, message);
        }
    }
}