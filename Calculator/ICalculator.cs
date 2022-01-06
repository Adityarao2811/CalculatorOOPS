using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOOPS
{
    public interface ICalculator
    {
        public void Add(int a, int b);
        public void Permutation(int a, int b);
        public void Combination(int a, int b);
        public void Subtract(int a, int b);
        public void Divide(int a, int b);
        public void Multiply(int a, int b);
    }
}
