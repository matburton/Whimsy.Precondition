
namespace Whimsy.Precondition.Injection.Core.Logging
{
    public interface ILog
    {
        /// <remarks>Never throws. Thread safe</remarks>
        ///
        void Log(LogLevel level, string message);
    }
}