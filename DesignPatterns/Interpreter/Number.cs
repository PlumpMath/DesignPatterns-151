using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
    public class Number : IExpression 
    {
        private int _number;
        
        public Number(int number)
        {
            _number = number;
        }

        public int Interpret(Dictionary<String, IExpression> variables) 
        {
            return _number;
        }
    }
}
