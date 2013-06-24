using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class EngineController : IEngineController
    {
        public bool Running
        {
            get;
            private set;
        }

        public void Start()
        {
            Running = true;
            Console.WriteLine("Engine started");
        }

        public void Stop()
        {
            Running = false;
            Console.WriteLine("Engine stopped");
        }
    }
}
