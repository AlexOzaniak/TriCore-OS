using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriCore_OS.Grafika;

namespace TriCore_OS
{
    internal class AppsMenuContr
    {
        MainGraphics mainUI = new MainGraphics();
        internal void AppsMenuControl()
        {
            Console.Clear();
            mainUI.mainGraphics();

        }
    }
}
