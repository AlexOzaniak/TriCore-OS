using System;
using System.IO;

namespace TriCore_OS.Login
{
    public class LoginDetailsExtraction : FileLogin
    {
        
        public string SavedUserName { get; private set; }
        public string SavedPassword { get; private set; }

        FileRegistration registration = new FileRegistration();

        public void ExtractLoginDetails(FileLogin login)
        {
            
            login.FilePath = this.FilePath;

            if (File.Exists(FilePath) == false)
                
            {
                File.Create(FilePath).Close();
                Console.WriteLine("Súbor bol vytvorený: " + FilePath);
                return;
            }

           
            string[] lines = File.ReadAllLines(FilePath);

            

            
            ExtractInfo(login);
        }

        public void ExtractInfo(FileLogin login)
        {
            string firstLine = File.ReadLines(login.FilePath).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(firstLine))
                return;

            string[] parts = firstLine.Split(';');

            if (parts.Length == 2)
            {
                SavedUserName = parts[0];

                
                SavedPassword = CaesarDecrypt(parts[1]);

              
            }

        }
        public string CaesarDecrypt(string input, int shift = 3)
        {
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

