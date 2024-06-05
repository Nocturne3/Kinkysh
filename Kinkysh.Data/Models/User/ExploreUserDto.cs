namespace Kinkysh.Data.Models.User;

public class ExploreUserDto
{
    public int UserId { get; set; }
    
    public string Username { get; set; } = null!;
    
    public int Age { get; set; }
    
    public string ProfilePictureUrl { get; set; } = null!;
}