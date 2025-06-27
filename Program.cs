namespace MohalemBank;

internal class Program
{
    private static bool Auth(string username, string password)
    {
        if (username == "admin" && password == "nimda")
            return true;
        else
            return false;
        // ( username == "admin" && password == "nimda"))
    }

    private static void ShowIntro()
    {
        var valid = true;
        string username = "";
        string password = "";
        Console.Clear();
        Console.WriteLine("********** Welcome to MOOHALEM Bank **********");
        Console.WriteLine(":: LOGIN FORM ::");
        while (valid)
        {
            Console.Write("Username: ");
            username = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(username))
                Console.WriteLine("Username can't be empty");
            else
                valid = false;
        }

        valid = true;
        while (valid)
        {
            Console.Write("Password: ");
            password = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(password))
                Console.WriteLine("Password can't be empty");
            else
                valid = false;
        }

        if (!Auth(username, password)) Console.WriteLine("Username/Password not registered");
    }

    static void ShowMenu()
    {
        Console.WriteLine(":: MENU ::");
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Withdraw");
        Console.WriteLine("4. User Management");
        Console.WriteLine("5. Exit");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Console.WriteLine("Balance: $1000");
                break;
            case "2":
                Console.WriteLine("Deposit functionality not implemented yet.");
                break;
            case "3":
                Console.WriteLine("Withdraw functionality not implemented yet.");
                break;
            case "4":
                Console.WriteLine("User Management functionality not implemented yet.");
                break;
            case "5":
                Console.WriteLine("Thank you for using MOOHALEM Bank!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    private static void Main(string[] args)
    {
        ShowIntro();
        ShowMenu();
    }
}