using Kinkysh.Data.Models.SignUp;

namespace Kinkysh.Data.Repositories.SignUp;

public interface ISignUpRepository
{
    Task SignUp(SignUpDto signUpRequest);
}