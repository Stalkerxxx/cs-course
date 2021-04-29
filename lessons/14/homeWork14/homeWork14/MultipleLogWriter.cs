using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace homeWork14
{
    class MultipleLogWriter : ILogWriter
    {
        public string MessageType { get; set; }
        public List<MultipleLogWriter> LogWriter { get; set; }
        public void LogInfo(string message)
        {
            MessageType = "Info";
            Console.WriteLine($"{DateTimeOffset.Now} {MessageType} {message}");
            File.AppendAllText("somefile.txt", $"{DateTimeOffset.Now} {MessageType} {message}\n");
        }

        public void LogWarning(string message)
        {
            MessageType = "Warning";
            Console.WriteLine($"{DateTimeOffset.Now} {MessageType} {message}");
            File.AppendAllText("somefile.txt", $"{DateTimeOffset.Now} {MessageType} {message}\n");
        }

        public void LogError(string message)
        {
            MessageType = "Error";
            Console.WriteLine($"{DateTimeOffset.Now} {MessageType} {message}");
            File.AppendAllText("somefile.txt", $"{DateTimeOffset.Now} {MessageType} {message}\n");
        }

        public MultipleLogWriter(List<MultipleLogWriter> logWriters)
        {
            LogWriter = logWriters;
        }
    }
}
