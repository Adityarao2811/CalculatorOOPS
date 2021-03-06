using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CalculatorOOPS
{
    public static class Utility
    {
        public static void ReadMenuforCalcType()
        {
            try
            {
                string line;
                using (StreamReader sr = new StreamReader(KeyStore.MenuFilePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(KeyStore.ExceptionCaughtMessage + e);
            }
        }
        public static void CalculateExpression(ICalculator calculator,string expression)
        {
            Regex regex = new Regex(@"^\d+[+-pc*/]\d+$");
            if (regex.IsMatch(expression))
            {
                string[] expObj = expression.Split(KeyStore.OperatorList);
                int firstOperand = Convert.ToInt32(expObj[0]);
                int secondOperand = Convert.ToInt32(expObj[1]);
                PerformOperations(calculator,expression,firstOperand,secondOperand);
            }
            else
            {
                Console.WriteLine(KeyStore.InvalidExpression);
            }
        }

        private static void PerformOperations(ICalculator calculator,string expression,int firstOperand,int secondOperand)
        {
            if (expression.Contains("+"))
            {
                calculator.Add(firstOperand, secondOperand);
            }
            else if(expression.Contains("-"))
            {
                calculator.Subtract(firstOperand, secondOperand);
            }
            else if (expression.Contains("/"))
            {
                calculator.Divide(firstOperand, secondOperand);
            }
            else if (expression.Contains("*"))
            {
                calculator.Multiply(firstOperand, secondOperand);
            }
            else if(expression.ToLower().Contains("p"))
            {
                calculator.Permutation(firstOperand, secondOperand);
            }
            else if (expression.ToLower().Contains("c"))
            {
                calculator.Combination(firstOperand, secondOperand);
            }
        }
        public static int Factorial(int num)
        {
            int fact=1;
            for(int i=1;i<=num;i++)
            {
                fact *= i;    
            }
            return fact;
        }
    }
    
}
