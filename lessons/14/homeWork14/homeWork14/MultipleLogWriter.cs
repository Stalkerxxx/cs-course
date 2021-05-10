using System;
using System.IO;
using System.Collections.Generic;

namespace homeWork14
{
    class MultipleLogWriter : ILogWriter
    {
        private readonly List<ILogWriter> _logWriter = new List<ILogWriter> {new ConsoleLogWriter(), new FileLogWriter()};
        public void LogInfo(string message)
        {
            Console.WriteLine($"{DateTimeOffset.Now} {"Info"} {message}");
            File.AppendAllText("somefile.txt", $"{DateTimeOffset.Now} {"Info"} {message}\n");
        }

        public void LogWarning(string message)
        {
            
            File.AppendAllText("somefile.txt", $"{DateTimeOffset.Now} {"Warning"} {message}\n");
        }

        public void LogError(string message)
        {
            Console.WriteLine($"{DateTimeOffset.Now} {"Error"} {message}");
            File.AppendAllText("somefile.txt", $"{DateTimeOffset.Now} {"Error"} {message}\n");
        }

        public MultipleLogWriter(List<ILogWriter> logWriters)
        {
            LogWriter = logWriters;
        }
    }
}
