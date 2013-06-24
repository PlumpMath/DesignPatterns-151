using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Composite : IComponent
    {
        public String Text { get; set; }

        private List<IComponent> componentList;

        public Composite()
        {
            componentList = new List<IComponent>();
        }

        public void add(IComponent component)
        {
            componentList.Add(component);
        }

        public void remove(IComponent component)
        {
            componentList.Remove(component);
        }

        public void draw()
        {
            foreach (IComponent comp in componentList)
                comp.draw();
        }
    }
}
