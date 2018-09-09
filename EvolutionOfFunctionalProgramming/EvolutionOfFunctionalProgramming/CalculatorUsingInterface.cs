using System;

namespace EvolutionOfFunctionalProgramming
{
    /// <summary>
    /// This calculator class is using Interface
    /// </summary>
    public static class CalculatorUsingInterface
    {

        public interface IMathOperation
        {
            int Compute(int a, int b);
        }

        private class AddOperation : IMathOperation
        {
            public int Compute(int a, int b)
            {
                return a + b;
            }
        }

        private class SubOperation : IMathOperation
        {
            public int Compute(int a, int b)
            {
                return a - b;
            }
        }

        private class MulOperation : IMathOperation
        {
            public int Compute(int a, int b)
            {
                return a * b;
            }
        }

        private class DivOperation : IMathOperation
        {
            public int Compute(int a, int b)
            {
                return a / b;
            }
        }


        private static IMathOperation GetOperation(char oper)
        {
            switch (oper)
            {
                case '+': return new AddOperation();
                case '-': return new SubOperation();
                case '*': return new MulOperation();
                case '/': return new DivOperation();

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

            return GetOperation(oper).Compute(left, right);
        }

    }
}
