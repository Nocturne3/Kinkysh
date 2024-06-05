using Kinkysh.Data.Models.User;

namespace Kinkysh.Data.Repositories.User;

public interface IUserRepository
{
    Task<UserDao> GetUserById(int id);
    
    Task<List<UserDao>> GetUsers();
    
    Task<(List<ExploreUserDto> users, int totalPages)> GetExploreUsers(int pageNumber, int pageSize);
    
    Task<ExploreUserDto> GetExploreUserById(int id);
    
    Task CreateUser(UserDao user);
    
    Task<PrivateUserDto> GetPrivateUserById(int id);
}