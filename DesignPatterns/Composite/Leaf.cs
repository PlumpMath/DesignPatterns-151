using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Leaf : IComponent
    {
        void IComponent.draw()
        {
            Console.WriteLine("Leaf");
        }
    }
}
