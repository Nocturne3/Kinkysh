namespace Kinkysh.Data.Models.User;

public class UserPicturesDao
{
    public int Id { get; set; }
    
    public string PictureUrl { get; set; } = null!;
    
    public int UserId { get; set; }
    
    public bool IsProfilePicture { get; set; }
}