using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
    public class Plus : IExpression
    {
        IExpression leftOperand;
        IExpression rightOperand;

        public Plus(IExpression left, IExpression right)
        {
            leftOperand = left;
            rightOperand = right;
        }

        public int Interpret(Dictionary<String, IExpression> variables)
        {
            return leftOperand.Interpret(variables) + rightOperand.Interpret(variables);
        }
    }
}
