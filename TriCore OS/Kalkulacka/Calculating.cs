using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.Kalkulacka
{
    internal class Calculating
    {
        internal void Calc()
        {
            Console.WriteLine("Zadaj priklad\n");
            string input = Console.ReadLine();

            List<string> elements = new List<string>();

            while (elements.Contains("("))
            {
                int intEnd = elements.IndexOf(")");
                int intStart = -1;

                for (int i = intEnd; i >= 0; i--)
                {
                    if (elements[i] == "(")
                    {
                        intStart = i;
                        break;
                    }
                }
            }


        }
    }
}
