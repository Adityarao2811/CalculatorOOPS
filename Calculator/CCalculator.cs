using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOOPS
{
    public class CCalculator : ICalculator
    {
        public void Add(int a, int b)
        {
            int sum = a - b;
            Console.WriteLine(sum);
        }
    }
}
