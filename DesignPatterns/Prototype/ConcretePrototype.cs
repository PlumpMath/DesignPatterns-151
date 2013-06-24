using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class ConcretePrototype : ICloneable
    {
        public int X { get; set; }

        public ConcretePrototype(int x)
        {
            this.X = x;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
