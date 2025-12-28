using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.Spustanie_Programov
{
    internal class StartingProgram
    {
        public void StartProgram()
        {
            Console.Write(" Which app do u want to open:");
            string input = Console.ReadLine().Trim();

            Process.Start(new ProcessStartInfo
            {
                FileName = input,
                UseShellExecute = true
            });

        }
    }
}


