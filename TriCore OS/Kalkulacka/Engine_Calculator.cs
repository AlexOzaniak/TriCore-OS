using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.Kalkulacka
{
    internal class Engine_Calculator
    {
        public void StartCalculator()
        {
            Console.WriteLine("Vitaj v TriCore Calculator!");
            Thread.Sleep(500);
            Console.WriteLine("Pre spustenie stlac 'ENTER'");
            Console.ReadLine();
            Console.Clear();


        }
    }
}
