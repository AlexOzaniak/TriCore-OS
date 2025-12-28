using System;
using System.IO;

namespace TriCore_OS.Login
{
    public class LoginDetailsExtraction
    {
        

        public string SavedUserName { get; private set; }
        public string SavedPassword { get; private set; }

       

        public void ExtractLoginDetails(FileLogin login)
        {
          
            
            if (File.Exists(login.FilePath) == false)
                
            {

                File.Create(login.FilePath).Close();
                Console.WriteLine("Súbor bol vytvorený: " +login.FilePath);
                return;
            }

           
            string[] lines = File.ReadAllLines(login.FilePath);
            

            

            
            ExtractInfo(login);
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