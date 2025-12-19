using System.Diagnostics;
using TriCore_OS.Login;

public class FileEngine : FileLogin
{
    public void EngineStart(LoginDetailsExtraction extraction)
    {
        FileRegistration registration = new FileRegistration();
        Console.CursorVisible = true;

        string roamingFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        FilePath = Path.Combine(roamingFolder, @"userlogininfo.txt");
        PaswordEncrypting encrypting = new PaswordEncrypting();
        










        registration.FilePath = FilePath;
        extraction.FilePath = FilePath;
        Console.Clear();
        extraction.ExtractLoginDetails(extraction);
        Console.WriteLine("Hello User Please Insert Your Username");
        string InputUsername = Console.ReadLine();
        Console.WriteLine($"Hello {extraction.SavedUserName} Please Insert Your Password");
        string InputPassword = Console.ReadLine();
        Console.WriteLine(InputPassword);
     
       


        if (InputUsername != extraction.SavedUserName)
        {
            Console.WriteLine("wrong name");
            registration.RegisterDetails();
        }
        else if (InputPassword != extraction.SavedPassword)
        {
            Console.WriteLine("wrong Password");

        }
        else
        {
            Console.WriteLine("Access Granted");
            Process.Start("Spotify");
            Console.WriteLine("Welcome to our system ");

        }






    }
}
