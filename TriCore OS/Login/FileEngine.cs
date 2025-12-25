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
        registration.FilePath = FilePath;
    }

    public void FileLoginProcess(LoginDetailsExtraction extraction)
    {
        Login_Engine engine = new Login_Engine();

        extraction.FilePath = FilePath;
        extraction.ExtractLoginDetails(extraction);
        
        string InputUsername = Console.ReadLine();
        engine.CenteringCursorPassword();
        string InputPassword = Console.ReadLine();


        if (InputUsername != extraction.SavedUserName)
        {
            Console.WriteLine("wrong name");
            registration.RegisterDetails();
        }
        else if (InputPassword != extraction.SavedPassword)
        {
            Console.WriteLine("wrong Password");
            Console.Clear();
        }
        else
        {
            //Console.WriteLine("Access Granted");          //this is for development
        }
    }
}
