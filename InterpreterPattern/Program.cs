using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Interpreter;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            String expression = "w x z - +";
            Evaluator sentence = new Evaluator(expression);
            Dictionary<String, IExpression> variables = new Dictionary<String, IExpression>();
            variables.Add("w", new Number(5));
            variables.Add("x", new Number(10));
            variables.Add("z", new Number(42));
            int result = sentence.Interpret(variables);
            Console.WriteLine(result);
        }
    }
}
