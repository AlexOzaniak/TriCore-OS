using System;
using System.IO;

namespace TriCore_OS.Login
{
    public class LoginDetailsExtraction:FileLogin
    {
        FileRegistration registration = new FileRegistration();

        public string SavedUserName { get; private set; }
        public string SavedPassword { get; private set; }

       

        public void ExtractLoginDetails(LoginDetailsExtraction extraction1)
        {
          
            
           

            if (File.Exists(FilePath) == false)
                
            {

                File.Create(FilePath).Close();
                Console.WriteLine("Súbor bol vytvorený: " + FilePath);
                return;
            }

           
            string[] lines = File.ReadAllLines(FilePath);
            FileLogin login1 = new FileLogin();

            

            
            ExtractInfo(login1);
        }

        public void ExtractInfo(FileLogin login)
        {
            string firstLine = File.ReadLines(login.FilePath).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(firstLine))
                return;

            string[] parts = firstLine.Split(';');

            
                SavedUserName = parts[0];

                
                SavedPassword = CaesarDecrypt(parts[1]);

              
            

        }
        public string CaesarDecrypt(string input, int shift = 3)
        { // niektore z tohto je gpt lebo sm absolutne nechapal ako mam urobit to sifru
            char[] buffer = input.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char c = buffer[i];

                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    c = (char)((((c - offset) - shift + 26) % 26) + offset);
                }

                buffer[i] = c;
            }

            return new string(buffer);
        }


    }
}

