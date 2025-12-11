using System;
using System.IO;

namespace TriCore_OS.Login
{
    public class LoginDetailsExtraction : FileLogin
    {
        // Fields to store the extracted login details
        public string SavedUserName { get; private set; }
        public string SavedPassword { get; private set; }

        FileRegistration registration = new FileRegistration();

        public void ExtractLoginDetails(FileLogin login)
        {
            // Ensure the registration instance uses the same Path as this extractor
            login.Path = this.Path;

            if (File.Exists(Path) == false)
            {
                Console.WriteLine("No registration found. Please register first.");
                registration.RegisterDetails();
                return;
            }

            // File exists - read lines
            string[] lines = File.ReadAllLines(Path);

            

            // Call ExtractInfo to parse login details from file
            ExtractInfo(login);
        }

        public void ExtractInfo(FileLogin login)
        {
            foreach (string line in File.ReadLines(login.Path))
            {
                string[] parts = line.Split(';');
                if (parts.Length == 2) // 
                {
                    SavedUserName = parts[0]; 
                    SavedPassword = parts[1]; 

                    Console.WriteLine($"Extracted Username: {SavedUserName}");
                    Console.WriteLine($"Extracted Password: {SavedPassword}");
                }
            }
        }
    }
}
