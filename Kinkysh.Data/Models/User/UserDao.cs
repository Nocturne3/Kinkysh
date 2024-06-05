namespace Kinkysh.Data.Models.User;

public class UserDao
{
    public int Id { get; set; }

    public string Username { get; set; } = string.Empty;
    
    public int Age { get; set; }
    
    public string Email { get; set; } = string.Empty;
    
    public string Password { get; set; } = string.Empty;
    
    public string City { get; set; } = string.Empty;
}