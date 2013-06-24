using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
    public class Evaluator : IExpression
    {
        private IExpression syntaxTree;

        public Evaluator(String expression)
        {
            Stack<IExpression> expressionStack = new Stack<IExpression>();

            var temp = expression.Split(' ');

            foreach (String token in temp)
            {
                if (token.Equals("+"))
                {
                    IExpression subExpression = new Plus(expressionStack.Pop(), expressionStack.Pop());
                    expressionStack.Push(subExpression);
                }
                else if (token.Equals("-"))
                {
                    // it's necessary remove first the right operand from the stack
                    IExpression right = expressionStack.Pop();
                    // ..and after the left one
                    IExpression left = expressionStack.Pop();
                    IExpression subExpression = new Minus(left, right);
                    expressionStack.Push(subExpression);
                }
                else
                    expressionStack.Push(new Variable(token));
            }
            syntaxTree = expressionStack.Pop();
        }

        public int Interpret(Dictionary<String, IExpression> context)
        {
            return syntaxTree.Interpret(context);
        }
    }
}
