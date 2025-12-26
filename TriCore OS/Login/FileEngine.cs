using System.Diagnostics;
using TriCore_OS;
using TriCore_OS.Login;

public class FileEngine : FileLogin
{
     FileRegistration registration = new FileRegistration();
    public void FileStart(LoginDetailsExtraction extraction)
    {
        Console.CursorVisible = true;

        string roamingFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        FilePath = Path.Combine(roamingFolder, @"userlogininfo.txt");
        PaswordEncrypting encrypting = new PaswordEncrypting();








    }

    public void FileLoginProcess(LoginDetailsExtraction extraction)
    {
    Login_Engine engine = new Login_Engine();

        extraction.FilePath = FilePath;
        extraction.ExtractLoginDetails(extraction);
        
        string InputUsername = Console.ReadLine();
        engine.CenteringCursorPassword();
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
            Console.Clear();
            Console.WriteLine("Logging In");
            
            for ( int i = 0; i < 10; i++ )
            {
                
                Console.Write(">");
                Thread.Sleep(400);
                
            }
            Console.WriteLine();
            
            Console.WriteLine($"{InputUsername.ToUpper()} Welcome Back!");

        }






    }
}
