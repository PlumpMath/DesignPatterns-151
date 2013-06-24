using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
    public class Variable : IExpression
    {
        private String _name;

        public Variable(String name) 
        {
            _name = name;
        }

        public int Interpret(Dictionary<String, IExpression> variables)
        {
            return variables.FirstOrDefault(c => c.Key.Equals(_name)).Value.Interpret(variables);
        }
    }
}
