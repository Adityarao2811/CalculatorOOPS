using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOOPS
{
    public static class ReadAndWriteInConsole
    {
        public static void ReadMenuforCalcType(string menu)
        {
            string line;
            using (StreamReader sr = new StreamReader(menu))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
