using MelonLoader;

namespace ComedyModPublic
{
    public static class Logging
    {
        private static MelonLogger.Instance logger;

        public static void Initialize(MelonLogger.Instance loggerInstance)
        {
            logger = loggerInstance;
        }

        public static void Log(string message)
        {
            logger.Msg(message);
        }

        public static void Log(object message)
        {
            logger.Msg(message.ToString());
        }

        public static void Log(string message, params object[] args)
        {
            logger.Msg(string.Format(message, args));
        }

        public static void LogSceneLoad(string sceneName, int buildIndex)
        {
            logger.Msg($"Scene \"{sceneName}\" with build index {buildIndex} has been loaded.");
        }

        public static void Warn(string message)
        {
            logger.Warning(message);
        }
    }
}