using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public interface IDrawingAPI
    {
        void drawCircle(double x, double y, double radius);
    }
}
