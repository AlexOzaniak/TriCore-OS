using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriCore_OS.Grafika;

namespace TriCore_OS.Kalkulacka
{
    internal class Engine_Calculator
    {
        Calculator calculator = new Calculator();
        CalculatorGraphics graphics = new CalculatorGraphics();

        public void StartCalculator()
        {
            graphics.CalculatorUI();
            Console.WriteLine("Vitaj v TriCore Calculator!");
            Thread.Sleep(2000);
            Console.Clear();
            calculator.Run();

        }
    }
}
