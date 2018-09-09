using System;

namespace EvolutionOfFunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //var res = CalculatorUsingDelegate.Eval("1 + 2");
            //var res = CalculatorUsingAnonymousMethod.Eval("1 + 2");
            //var res = CalculatorUsingInterface.Eval("1 + 2");
            var res = CalculatorUsingLambda.Eval("1 + 2");
            Console.WriteLine(res);
            Console.ReadLine();

        }
    }
}
