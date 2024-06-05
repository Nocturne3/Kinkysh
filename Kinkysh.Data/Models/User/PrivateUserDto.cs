namespace Kinkysh.Data.Models.User;

public class PrivateUserDto
{
    public int UserId { get; set; }
    
    public string Username { get; set; } = null!;
    
    public int Age { get; set; }
    
    public string Email { get; set; } = null!;
    
    public string City { get; set; } = null!;
    
    public string ProfilePictureUrl { get; set; } = null!;
    
    public string Description { get; set; } = null!;
}