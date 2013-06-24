using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Composite;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite comp = new Composite();
            comp.Text = "first";
            Leaf leaf = new Leaf();

            comp.add(leaf);
            comp.draw();
        }
    }
}
