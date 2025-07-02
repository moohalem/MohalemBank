namespace Services;

public class AuthService
{
    public static bool Auth(string username, string password)
    {
        if (username == "admin" && password == "nimda")
            return true;
        else
            return false;
        // ( username == "admin" && password == "nimda"))
    }
}