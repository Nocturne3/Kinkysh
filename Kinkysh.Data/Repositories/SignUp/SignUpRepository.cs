using Kinkysh.Data.Models.SignUp;
using Kinkysh.Data.Models.User;
using Kinkysh.Data.Repositories.User;

namespace Kinkysh.Data.Repositories.SignUp;

public class SignUpRepository(IUserRepository userRepository) : ISignUpRepository
{
    public Task SignUp(SignUpDto signUpRequest)
    {
        var user = new UserDao()
        {
            Email = signUpRequest.Email,
            Password = signUpRequest.Password,
            Username = signUpRequest.Username,
            Age = signUpRequest.Age,
            City = signUpRequest.City
        };
        
        return userRepository.CreateUser(user);
    }
}