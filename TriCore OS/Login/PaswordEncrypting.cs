using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.Login
{
    public class PaswordEncrypting
    {
       
        FileRegistration registration = new FileRegistration();
        
        

        public string Encryption()
        {

            char[] znaky = registration.GetRegisterPassword().ToCharArray();

            for (int i = 0; i < znaky.Length; i++)
            {
                if (char.IsLetter(znaky[i]))
                {
                    znaky[i] = (char)(znaky[i] + 3);
                }
            }

            return new string(znaky);
        }
        

    }
}
