using Custom_Dependency_injection_Framework.Contracts;
using Custom_Dependency_injection_Framework.Logger;
using System;

namespace Custom_Dependency_injection_Framework
{
    public class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            Engine engine = new Engine(logger);

            engine.Start();
            engine.End();
        }
    }
}
