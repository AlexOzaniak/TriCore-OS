using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
namespace TriCore_OS.Login
{


    namespace TriCore_OS.Login
    {
        internal class LoginDetailsExtraction : FileLogin
        {
            FileRegistration registration = new FileRegistration();

            public string[] ExtractName()
            {
                if (!File.Exists(Path))
                {
                    registration.RegisterDetails();
                }

                string[] details = File.ReadAllLines(Path);

                if (details.Length == 0)
                {
                    registration.RegisterDetails();
                    details = File.ReadAllLines(Path);
                }

                Username = new[] { details[0] };
                return Username;
            }

            public string[] ExtractPassword()
            {
                if (!File.Exists(Path))
                {
                    registration.RegisterDetails();
                }


                string[] details = File.ReadAllLines(Path);
                if (details.Length == 0)
                {
                    registration.RegisterDetails();
                    details = File.ReadAllLines(Path);
                }


                Password = new[] { details[1] };
                return Password;
            }
        }
    }
}
