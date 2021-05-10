using System;
using System.IO;

namespace homeWork14
{
    class FileLogWriter : ILogWriter
    {
        public void LogInfo(string message)
        {
            File.AppendAllText("somefile.txt", $"{DateTimeOffset.Now} {"Info"} {message}\n");
        }

        public void LogWarning(string message)
        {
            File.AppendAllText("somefile.txt", $"{DateTimeOffset.Now} {"Warning"} {message}\n");
        }

        public void LogError(string message)
        {
            File.AppendAllText("somefile.txt", $"{DateTimeOffset.Now} {"Error"} {message}\n");
        }
    }
}
