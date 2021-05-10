using System;

namespace homeWork14
{
    class ConsoleLogWriter : ILogWriter
    {
        public void LogInfo(string message)
        {
            Console.WriteLine($"{DateTimeOffset.Now} {"Info"} {message}");
        }

        public void LogWarning(string message) 
        {
            Console.WriteLine($"{DateTimeOffset.Now} {"Warning"} {message}");
        }

        public void LogError(string message)
        {
            Console.WriteLine($"{DateTimeOffset.Now} {"Error"} {message}");
        }
    }
}
