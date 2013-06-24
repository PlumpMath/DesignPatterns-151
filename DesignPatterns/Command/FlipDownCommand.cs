using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class FlipDownCommand : ICommand
    {
        private Light _light;

        public FlipDownCommand(Light light)
        {
            _light = light;
        }

        public Light receiver
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void execute()
        {
            _light.TurnOff();
        }
    }
}
