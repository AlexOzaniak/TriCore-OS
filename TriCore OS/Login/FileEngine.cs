using TriCore_OS.Login;

public class FileEngine : FileLogin
{
    public void EngineStart(LoginDetailsExtraction extraction)
    {
        FileRegistration registration = new FileRegistration();
        

        Console.WriteLine("Before we start, enter path to your .txt file:");
        Path = Console.ReadLine();
        registration.Path = Path;
        extraction.Path = Path;
        Console.Clear();
        extraction.ExtractLoginDetails(extraction);
        Console.WriteLine("Hello User Please Insert Your Username");
        string InputUsername = Console.ReadLine();
        Console.WriteLine($"Hello {extraction.SavedUserName} Please Insert Your Password");
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
            Console.WriteLine("Access Granted");
        }
        SaveDetails();





    }
}
