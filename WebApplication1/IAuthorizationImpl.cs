namespace WebApplication1;

public interface IAuthorizationImpl
{ 
    bool CheckValidAuth(string usernameInput, string passwordInput);
}