using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Command;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Light lamp = new Light();
            ICommand switchUp = new FlipUpCommand(lamp);
            ICommand switchDown = new FlipDownCommand(lamp);

            Switch s = new Switch();

            s.StoreAndExecute(switchUp);

            s.StoreAndExecute(switchDown);
        }
    }
}
