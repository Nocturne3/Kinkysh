using Kinkysh.Data.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Kinkysh.Data.Repositories.UserPictures;

public class UserPicturesRepository(DataContext context) : IUserPicturesRepository
{
    public async Task<List<UserPicturesDao>> GetUserPictures(int userId)
    {
        var userPictures = await context.UserPictures.Where(x => x.UserId == userId).ToListAsync();
        
        return userPictures;
    }

    public async Task<UserPicturesDao> GetUserProfilePicture(int userId)
    {
        var userProfilePicture = await context.UserPictures.FirstOrDefaultAsync(x => x.UserId == userId && x.IsProfilePicture);
        
        if (userProfilePicture == null)
        {
            throw new Exception("User does not have a profile picture");
        }
        
        return userProfilePicture;
    }
}