using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TriCore_OS.Login
{
    public class FileLogin
    {
        protected string Username { get; set; }
        protected string Password { get; set; }
        public string FilePath { get; set; }

       

        public void SaveDetails()
        {
            using (StreamWriter file = new StreamWriter(FilePath, false))
            {
                file.WriteLine($"{Username};{Password}");
            }

        }
    }
}
