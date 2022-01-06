using System;

namespace CalculatorOOPS
{
    public static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string a = Keystore.MenuFilePath;
                ReadAndWriteInConsole.ReadMenuforCalcType(a);
                
            } 
            catch(Exception e)
            {
                Console.WriteLine("Exception caught: " + e);
            }
        }
    }
}
