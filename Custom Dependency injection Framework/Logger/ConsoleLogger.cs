using Custom_Dependency_injection_Framework.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_Dependency_injection_Framework.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
