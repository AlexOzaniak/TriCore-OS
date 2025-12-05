using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.Login
{
    public class FileLogin
    {
         
        protected string[] Username { get;  set; }
        protected string[] Password { get;  set; }

        public string Path {  get; set; }




        public void SaveDetails()
        {
            File.WriteAllLines(new string (Path), new string []
                {
                Username[0],
                Password[0]});


        }
        
    }
}

