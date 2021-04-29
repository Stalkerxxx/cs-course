using System;
using System.IO;

namespace homeWork14
{
    class FileLogWriter : ILogWriter
    {
        public string MessageType { get; set; }
        public void LogInfo(string message)
        {
            MessageType = "Info";
            File.AppendAllText("somefile.txt", $"{DateTimeOffset.Now} {MessageType} {message}\n");
        }

        public void LogWarning(string message)
        {
            MessageType = "Warning";
            File.AppendAllText("somefile.txt", $"{DateTimeOffset.Now} {MessageType} {message}\n");
        }

        public void LogError(string message)
        {
            MessageType = "Error";
            File.AppendAllText("somefile.txt", $"{DateTimeOffset.Now} {MessageType} {message}\n");
        }
    }
}
