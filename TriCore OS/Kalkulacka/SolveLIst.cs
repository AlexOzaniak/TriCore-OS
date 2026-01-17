using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.Kalkulacka
{
    public class SolveLIst
    {
        public static double SolveWholeList(List<string> elements)
        {
            List<string> pracovna = new List<string>(elements);
            
            for (int i = 0; i < pracovna.Count; i++)
            {
                if (pracovna[i] == "*" || pracovna[i] == "/")
                {
                    double a = double.Parse(pracovna[i - 1]);
                    double b = double.Parse(pracovna[i + 1]);
                    double r = (pracovna[i] == "*") ? a * b : a / b;

                    pracovna[i - 1] = r.ToString();
                    pracovna.RemoveAt(i);
                    pracovna.RemoveAt(i);
                    i--;
                }
            }

            double vysledok = double.Parse(pracovna[0]);
            for (int i = 1; i < pracovna.Count; i += 2)
            {
                double dalsie = double.Parse(pracovna[i + 1]);
                if (pracovna[i] == "+") vysledok += dalsie;
                else vysledok -= dalsie;
            }
            return vysledok;
        }
    }
}
