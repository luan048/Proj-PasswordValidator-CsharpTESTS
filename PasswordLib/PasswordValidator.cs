namespace PasswordLib;

public class PasswordValidator
{
    public static bool IsValid(string password)
    {
        return password.Length >= 8;
    }
}