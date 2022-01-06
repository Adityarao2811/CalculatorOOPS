using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOOPS
{
    class TCalculator : ICalculator
    {
        public void Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(KeyStore.AnswerOutputMessage+sum);
        }
        public void Subtract(int a, int b)
        {
            int difference = a - b;
            Console.WriteLine(difference);
        }
        public void Divide(int a, int b)
        {
            float quotient = (float)a / b;
            Console.WriteLine(quotient);
        }

        public void Multiply(int a, int b)
        {
            int product = a * b;
            Console.WriteLine(product);
        }
    }
}
