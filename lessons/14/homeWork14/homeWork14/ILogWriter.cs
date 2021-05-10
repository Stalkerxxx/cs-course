namespace homeWork14
{
    interface ILogWriter
    {
        void LogInfo(string message);
        void LogWarning(string massage);
        void LogError(string massage);
    }
}
