using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class CircleShape : Shape
    {
        private double x, y, radius;
        
        public CircleShape(double x, double y, double radius, IDrawingAPI drawingAPI) : base(drawingAPI)
        {
            this.x = x; this.y = y; this.radius = radius;
        }

        public override void draw()
        {
            drawingAPI.drawCircle(x, y, radius);
        }

        public override void resizeByPercentage(double pct)
        {
            radius *= pct;
        }
    }
}
