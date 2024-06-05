using Kinkysh.Data.Models.User;
using Kinkysh.Data.Repositories.UserPictures;
using Microsoft.EntityFrameworkCore;

namespace Kinkysh.Data.Repositories.User;

public class UserRepository(DataContext context, IUserPicturesRepository picturesRepository) : IUserRepository
{
    public async Task<UserDao> GetUserById(int id)
    {
        var user = await context.Users.FindAsync(id);
        
        if (user is null)
        {
            throw new Exception("User not found");
        }
        
        return user;
    }

    public async Task<List<UserDao>> GetUsers()
    {
        var users = await context.Users.ToListAsync();
        
        return users;
    }

    public async Task<(List<ExploreUserDto> users, int totalPages)> GetExploreUsers(int pageNumber, int pageSize)
    {
        var users = await context.Users
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .Select(x => new ExploreUserDto {
            UserId = x.Id,
            Username = x.Username,
            Age = x.Age
        }).ToListAsync();

        foreach (var exploreUserDto in users)
        {
            exploreUserDto.ProfilePictureUrl =
                (await picturesRepository.GetUserProfilePicture(exploreUserDto.UserId)).PictureUrl;
        }
        
        var totalUsers = await context.Users.CountAsync();
        var totalPages = (int) Math.Ceiling((double)totalUsers / pageSize);

        return (users, totalPages);
    }

    public async Task<ExploreUserDto> GetExploreUserById(int id)
    {
        var user = await context.Users
            .Select(x => new ExploreUserDto
            {
                UserId = x.Id,
                Username = x.Username,
                Age = x.Age
            })
            .FirstOrDefaultAsync(x => x.UserId == id);
        
        if (user is null)
        {
            throw new Exception("User not found");
        }
        
        user.ProfilePictureUrl = (await picturesRepository.GetUserProfilePicture(user.UserId)).PictureUrl;
        
        return user;
    }

    public async Task CreateUser(UserDao user)
    {
        await context.Users.AddAsync(user);
        await context.SaveChangesAsync();
    }

    public async Task<PrivateUserDto> GetPrivateUserById(int id)
    {
        var user = await context.Users
            .Select(x => new PrivateUserDto
            {
                UserId = x.Id,
                Username = x.Username,
                Age = x.Age,
                Email = x.Email,
                City = x.City,
            })
            .FirstOrDefaultAsync(x => x.UserId == id);

        if (user is null)
        {
            throw new Exception("User not found");
        }
        
        user.ProfilePictureUrl = (await picturesRepository.GetUserProfilePicture(user.UserId)).PictureUrl;
        
        return user;
    }
}