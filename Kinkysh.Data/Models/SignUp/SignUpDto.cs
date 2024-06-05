namespace Kinkysh.Data.Models.SignUp;

public class SignUpDto
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    
    public int Age { get; set; }
    
    public string City { get; set; } = string.Empty;
}