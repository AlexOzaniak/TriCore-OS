using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TriCore_OS.Grafika
{
    internal class logoSchreen
    {
        public void StartUI()
        {
            string logoScreen = @"
   .----.  .----.  .----.   .----.  .----.  .----.
  /  /\  \/  /\  \/  /\  \ /  /\  \/  /\  \/  /\  \
 /__/_/___\_/__\_/__/_/___\_/__/_/___\_/__\_/__/_/__\
 |  TRI  |  CORE  |   O S   |   v2.5   |  LOADING   |
 \  \/  /\/  \/  /\/  \/  /\/  \/  /\/  \/  /\/  \/  /
  '----'  '----'  '----'   '----'  '----'  '----'
";
            Console.Clear();
            Console.Write(logoScreen);

        }

        public void LoadingScreen()
        {

        }
    }
}
