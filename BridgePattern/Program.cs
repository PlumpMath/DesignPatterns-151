using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Bridge;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
           Shape[] shapes = new Shape[] {
           new CircleShape(1, 2, 3, new DrawingAPI()),
           new CircleShape(5, 7, 11, new DrawingAPI()),
       };
 
       foreach (Shape shape in shapes) {
           shape.resizeByPercentage(2.5);
           shape.draw();
       }
        }
    }
}
