using Custom_Dependency_injection_Framework.Contracts;
using Custom_Dependency_injection_Framework.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_Dependency_injection_Framework
{
    public class GameContainer
    {

        public void ConfigurServices()
        {

            CreateMapping<ILogger, ConsoleLogger>();
            CreateMapping<ILogger, ConsoleLogger>();
        }

    }
}
