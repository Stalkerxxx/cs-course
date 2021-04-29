namespace homeWork14
{
    interface ILogWriter
    {
        string MessageType { get; set; }
        void LogInfo(string message);
        void LogWarning(string massage);
        void LogError(string massage);
    }
}
