using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Adapter;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IEmployee> list = new List<IEmployee>();
            list.Add(new Employee("Tom"));
            list.Add(new Employee("Jerry"));
            list.Add(new ConsultantToEmployeeAdapter("Bruno"));  //consultant from existing class
            ShowHappiness(list);
        }

        //*** Code below from the existing library does not need to be changed ***
        static void ShowHappiness(List<IEmployee> list)
        {
            foreach (IEmployee i in list)
                i.ShowHappiness();
        }
    }
}
