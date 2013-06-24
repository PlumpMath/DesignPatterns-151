using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public interface IVehicleFacade
    {
        void Start();
        void Accelerate();
        void Brake();
        void Off();
    }
}
