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
            login.FilePath = this.FilePath;

            if (File.Exists(FilePath) == false)
            {
                Console.WriteLine("No registration found. Please register first.");
                registration.RegisterDetails();
                return;
            }

            // File exists - read lines
            string[] lines = File.ReadAllLines(FilePath);

            

            // Call ExtractInfo to parse login details from file
            ExtractInfo(login);
        }

        public void ExtractInfo(FileLogin login)
        {
            foreach (string line in File.ReadLines(login.FilePath))
            {
                string[] parts = line.Split(';');
                
                
                    SavedUserName = parts[0]; 
                    SavedPassword = parts[0]; 

                    Console.WriteLine($"Extracted Username: {SavedUserName}");
                    Console.WriteLine($"Extracted Password: {SavedPassword}");
                
            }
        }
    }
}
