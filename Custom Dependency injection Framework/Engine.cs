using Custom_Dependency_injection_Framework.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_Dependency_injection_Framework
{
    public class Engine
    {
        private ILogger logger;
        public Engine(ILogger logger)
        {
            this.logger = logger;
        }


        public void Start()
        {

            logger.Log("Game Started");
        
        }

        public void End()
        {

            logger.Log("Game Ended");

        }
    }
}
