using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public abstract class Shape
    {
        protected IDrawingAPI drawingAPI;

        public Shape(IDrawingAPI drawingAPI)
        {
            this.drawingAPI = drawingAPI;
        }

        public IDrawingAPI IDrawingAPI
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public abstract void draw();                             // low-level
        public abstract void resizeByPercentage(double pct);     // high-level
    }
}
