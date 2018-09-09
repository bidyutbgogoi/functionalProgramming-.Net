using System;

namespace EvolutionOfFunctionalProgramming
{
    /// <summary>
    /// This calculator class is using delegate
    /// </summary>
    public static class CalculatorUsingDelegate
    {
        private delegate int MathOperation(int a, int b);

        private static int Add(int a, int b) => a + b;
        private static int Sub(int a, int b) => a - b;
        private static int Mul(int a, int b) => a * b;
        private static int Div(int a, int b) => a / b;

        private static MathOperation GetOperation(char oper)
        {
            switch (oper)
            {
                case '+': return Add;
                case '-': return Sub;
                case '*': return Mul;
                case '/': return Div;

                default:
                    throw new InvalidOperationException();
            }
        }

        public static int Eval(string expr)
        {
            var parameters = expr.Split(new[] { ' ' },3);
            var left = Convert.ToInt32( parameters[0]);
            var right = Convert.ToInt32(parameters[2]);
            var oper = parameters[1][0];

            return GetOperation(oper)(left, right);
        }

    }
}
