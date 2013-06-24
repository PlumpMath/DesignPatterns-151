using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Facade;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFacade vehicle = new VehicleFacade(new EngineController(), new TransmissionController(),
              new TractionControlController(), new TachometerController());
            vehicle.Start();

            

            for (int i = 0; i < 20; i++)
            {
                System.Threading.Thread.Sleep(500);
                vehicle.Accelerate();
            }

            for (int i = 0; i < 30; i++)
            {
                System.Threading.Thread.Sleep(500);
                vehicle.Brake();
            }

            vehicle.Off();
        }
    }
}
