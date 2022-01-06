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
    }
}
