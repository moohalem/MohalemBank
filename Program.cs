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
        Console.Clear();
        Console.WriteLine(".:: MENU ::.");
        Console.WriteLine("1. Customers");
        Console.WriteLine("2. Accounts");
        Console.WriteLine("3. Fund Transfer");
        Console.WriteLine("4. Fund Transfer Statement");
        Console.WriteLine("5. Account Statement");
        Console.WriteLine("0. Exit");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                SubCustomertMenu();
                break;
            case "2":
                SubAccountMenu();
                break;
            case "3":
                Console.WriteLine("Withdraw functionality not implemented yet.");
                break;
            case "4":
                Console.WriteLine("User Management functionality not implemented yet.");
                break;
            case "5":
                Console.WriteLine("User Management functionality not implemented yet.");
                break;
            case "0":
                Console.Clear();
                Console.WriteLine("Thank you for using MOHALEM Bank!");
                Environment.Exit(0);
                break;
            default:
                Console.Clear();
                Console.WriteLine("Invalid choice. Please try again.");
                Thread.Sleep(1000);
                break;
        }
    }

    static void SubCustomertMenu()
    {
        int subCustomerMenuChoice = -1;
        do
        {
            Console.Clear();
            Console.WriteLine(".:: CUSTOMER MENU ::.");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Delete Customer");
            Console.WriteLine("3. Update Customer");
            Console.WriteLine("4. View Customer");
            Console.WriteLine("0. Back to main menu");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": break;
                case "2": break;
                case "3": break;
                case "4": break;
                case "0": ShowMenu(); break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(1000);
                    break;
            }
        } while (subCustomerMenuChoice != 0);
    }

    static void SubAccountMenu()
    {
        int subAccountMenuChoice = -1;
        do
        {
            Console.Clear();
            Console.WriteLine(".:: ACCOUNTS MENU ::.");
            Console.WriteLine("1. Add Account");
            Console.WriteLine("2. Delete Account");
            Console.WriteLine("3. Update Account");
            Console.WriteLine("4. View Account");
            Console.WriteLine("0. Back to main menu");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": break;
                case "2": break;
                case "3": break;
                case "4": break;
                case "0": ShowMenu(); break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(1000);
                    break;
            }
        } while (subAccountMenuChoice != 0);
    }

    private static void Main(string[] args)
    {
        bool run = true;
        ShowIntro();
        while (run)
        {
            ShowMenu();
        }
    }
}