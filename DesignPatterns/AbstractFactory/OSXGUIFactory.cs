using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class OSXGUIFactory : IGUIFactory
    {
    
        IButton IGUIFactory.CreateButton()
        {
            return new OSXButton();
        }
    }
}
