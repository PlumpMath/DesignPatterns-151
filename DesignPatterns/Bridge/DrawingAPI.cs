using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class DrawingAPI : IDrawingAPI
    {
        public void drawCircle(double x, double y, double radius)
        {
            Console.WriteLine(String.Format("API.circle at {0}:{1} radius {2}", x, y, radius));
        }
    }
}
