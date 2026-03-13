namespace WebApplication1.Impl;

public class RegistrationImpl : IRegistrationImpl
{
    private string name { get; set; }
    private string pass { get; set; }

    public void Register(string username, string password)
    {
        pass = password;
        name = username;
        
        if(!CheckValidation())
            throw new Exception("Username or password is incorrect");
            
        // валидирую данные на sql инъекции и форматирование
        // отправляю в базу данных
    }

    bool CheckValidation()
    {
        return SqlInjectionValidate();
    }

    private bool SqlInjectionValidate()
    {
        //система валидации
        var val = name.Select(x => x).ToArray();
        return val.All(v => !v.Equals("2"));
    }
}