using MelonLoader;

namespace ComedyModPublic
{
    public static class Logging
    {
        private static MelonLogger.Instance _logger;

        public static void Initialize(MelonLogger.Instance loggerInstance)
        {
            _logger = loggerInstance;
        }

        public static void Log(string message)
        {
            _logger.Msg(message);
        }

        public static void Log(object message)
        {
            _logger.Msg(message.ToString());
        }

        public static void Log(string message, params object[] args)
        {
            _logger.Msg(string.Format(message, args));
        }

        public static void LogSceneLoad(string sceneName, int buildIndex)
        {
            _logger.Msg($"Scene {sceneName} with build index {buildIndex} has been loaded.");
        }

        public static void Warn(string message)
        {
            _logger.Warning(message);
        }
    }
}