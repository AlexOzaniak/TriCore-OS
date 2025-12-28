using System.Diagnostics;
using TriCore_OS;
using TriCore_OS.Login;

public class FileEngine : FileLogin
{
     FileRegistration registration = new FileRegistration();
    FileLogin login1 = new FileLogin();
    LoginDetailsExtraction extraction1 = new LoginDetailsExtraction();

    public void FileStart(LoginDetailsExtraction extraction)
    {

        Console.CursorVisible = true;

    }
    public void FileLoginProcess(LoginDetailsExtraction extraction,Login_Engine engine, FileLogin login)
    {
        string roamingFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        FilePath = Path.Combine(roamingFolder, @"userlogininfo.txt");
        login1.FilePath = this.FilePath;
        PaswordEncrypting encrypting = new PaswordEncrypting();
       


       
        string InputUsername = Console.ReadLine();
        engine.CenteringCursorPassword();
        string InputPassword = Console.ReadLine();
        Console.WriteLine(InputPassword);
        extraction.ExtractLoginDetails(extraction1);





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
