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
            Console.WriteLine(KeyStore.AnswerPrompt+sum);
        }
    }
}
