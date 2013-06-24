using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class OSXButton : IButton
    {
        void IButton.Paint()
        {
            System.Console.WriteLine("I'm a OSXButton");
        }
    }
}
