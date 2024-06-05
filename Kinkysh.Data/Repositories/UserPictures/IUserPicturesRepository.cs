using Kinkysh.Data.Models.User;

namespace Kinkysh.Data.Repositories.UserPictures;

public interface IUserPicturesRepository
{
    Task<List<UserPicturesDao>> GetUserPictures(int userId);
    
    Task<UserPicturesDao> GetUserProfilePicture(int userId);
}