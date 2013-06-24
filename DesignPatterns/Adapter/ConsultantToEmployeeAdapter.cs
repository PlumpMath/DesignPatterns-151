using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class ConsultantToEmployeeAdapter : Consultant, IEmployee 
    {
        public ConsultantToEmployeeAdapter(string name) : base(name)
        { 
        }

        public void ShowHappiness()
        {
            base.ShowSmile(); 
        }
    }
}
