using Custom_Dependency_injection_Framework.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Custom_Dependency_injection_Framework.Logger
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {

            using (StreamWriter writer = new StreamWriter("../../../logs.txt", true))
            {
                writer.WriteLine(message);
            }

        }
    }
}
