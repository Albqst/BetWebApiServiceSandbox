using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Contracts;

public class UserProfile
{
    [Required]
    [Display(Name = "Login")]
    string Login { get; set; }
    
    [Required]
    [Display(Name = "Email")]
    string Email { get; set; }
    
    [Required]
    [Display(Name = "Password")]
    string Password { get; set; }
}