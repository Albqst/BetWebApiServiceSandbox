using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class Controller
{
    public static bool flag = false;
    
    [HttpGet]
    public string GetBet()
    {
        return "Ваши ставки здесь!";
    }
    
    [HttpPost]
    public bool PostBet()
    {
        if (flag.Equals(true))
            flag = false;
        else if (flag.Equals(false))
            flag = true;
        return flag;
    }
}