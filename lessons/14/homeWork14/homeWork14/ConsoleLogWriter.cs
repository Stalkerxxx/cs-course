using System;

namespace homeWork14
{
    class ConsoleLogWriter : ILogWriter
    {
        public string MessageType { get; set; }
        public void LogInfo(string message)
        {
            MessageType = "Info";
            Console.WriteLine($"{DateTimeOffset.Now} {MessageType} {message}");
        }

        public void LogWarning(string message) 
        {
            MessageType = "Warning";
            Console.WriteLine($"{DateTimeOffset.Now} {MessageType} {message}");
        }

        public void LogError(string message)
        {
            MessageType = "Error";
            Console.WriteLine($"{DateTimeOffset.Now} {MessageType} {message}");
        }
    }
}
