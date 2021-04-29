using System;
using System.IO;
using System.Collections.Generic;

namespace homeWork14
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogWriter c = new ConsoleLogWriter();
            c.LogInfo("LOOL");
            c.LogWarning("Keke");
            c.LogError("SOS");

            FileLogWriter f = new FileLogWriter();
            f.LogError("LOL");
            f.LogInfo("Hello World");
            f.LogWarning("Salam");

            MultipleLogWriter m = new MultipleLogWriter(new List<MultipleLogWriter> { });
            m.LogError("LOL");
            m.LogInfo("KOLYA");
            m.LogWarning("SAYOP");
        }
    }
}
