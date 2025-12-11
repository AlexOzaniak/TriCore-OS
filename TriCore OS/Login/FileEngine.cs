using TriCore_OS.Login;

public class FileEngine : FileLogin
{
    public void EngineStart(LoginDetailsExtraction extraction)
    {
        FileRegistration registration = new FileRegistration();
        Console.CursorVisible = true;
        

        Console.WriteLine("Before we start, enter path to your .txt file:");
        FilePath = Console.ReadLine();
        registration.FilePath = FilePath;
        extraction.FilePath = FilePath;
        Console.Clear();
        extraction.ExtractLoginDetails(extraction);
        Console.WriteLine("Hello User Please Insert Your Username\n If this is your first time using our program please Type 'register' in the following bracket");

        string InputUsername = Console.ReadLine();
        if (InputUsername == "register")
        {
            registration.RegisterDetails();
        }
        Console.WriteLine($"Hello {extraction.SavedUserName} Please Insert Your Password");
        string InputPassword = Console.ReadLine();


        if (InputUsername != extraction.SavedUserName)
        {
            Console.WriteLine(" Registration ");
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
