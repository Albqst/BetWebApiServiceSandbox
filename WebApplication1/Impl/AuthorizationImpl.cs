namespace WebApplication1.Impl;

public class AuthorizationImpl : IAuthorizationImpl
{
    public bool CheckValidAuth(string usernameInput, string passwordInput)
    {
        try
        {
            const string nameBase = "Albert";
            const string passBase = "wrong_Password";

            return usernameInput == passBase && usernameInput == nameBase;
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }
}