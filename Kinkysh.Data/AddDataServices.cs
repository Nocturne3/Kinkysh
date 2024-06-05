using Kinkysh.Data.Repositories.SignUp;
using Kinkysh.Data.Repositories.User;
using Kinkysh.Data.Repositories.UserPictures;
using Microsoft.Extensions.DependencyInjection;

namespace Kinkysh.Data;

public static class AddDataServices
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserPicturesRepository, UserPicturesRepository>();
        services.AddScoped<ISignUpRepository, SignUpRepository>();
    }
}