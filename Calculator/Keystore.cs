using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOOPS
{
    public static class KeyStore
    {
        public static string MenuFilePath = @"C:\Users\pc\Source\Repos\CalculatorOOPS\Calculator\Text Files\Menu.txt";
        public static string ExpressionPromptMessage = "Enter the expression of form BOperatorA, examples : 10-3, 4+2, 5*6, 9p3, 6c2, 8/2, etc";
        public static string ExceptionCaughtMessage="Exception caught: ";

        public static string InvalidOption = "Invaid Option.Input valid option";

        public static string ContinueOrExit = "Type 1 to choose traditional Calculator and type 2 choose Crazy Calculator. Input 3 to exit";
        public static string Seperator = "********************************************************************************************";

        public static string AnswerOutputMessage = "The answer is ";

        public static char[] OperatorList = { '+', '-', '*', '/', 'p', 'c','P','C' };

        public static string InvalidExpression = "Invalid Expression";
    }
}
