using System;

namespace CalculatorOOPS
{
    public static class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator;
            Utility.ReadMenuforCalcType();
            int option = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (option == 1)
                {
                    calculator = new TCalculator();
                    EvaluateExpression();
                    
                }
                else if (option == 2)
                {
                    calculator = new CCalculator();
                    EvaluateExpression();
                }
                else
                {
                    Console.WriteLine(KeyStore.InvalidOption);
                }
                option = Convert.ToInt32(Console.ReadLine());
            } while (option != 3);

            void EvaluateExpression()
            {
                Console.WriteLine(KeyStore.ExpressionPromptMessage);
                string expression = Console.ReadLine();
                Utility.CalculateExpression(calculator, expression);
                Console.WriteLine(KeyStore.ContinueOrExit);
            }
        }


        
    }
}
