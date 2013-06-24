using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class Employee : IEmployee
    {
        private string name;

        public Employee(string name)
        {
            this.name = name;
        }

        void IEmployee.ShowHappiness()
        {
            Console.WriteLine("Employee " + this.name + " showed happiness");
        }
    }
}
