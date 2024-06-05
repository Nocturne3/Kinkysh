using Kinkysh.Data.Models.SignUp;
using Kinkysh.Data.Models.User;
using Kinkysh.Data.Repositories.SignUp;
using Kinkysh.Data.Repositories.User;
using Microsoft.AspNetCore.Components;

namespace Kinkysh.Components.Pages;

public partial class SignUp
{
    [Inject]
    private ISignUpRepository SignUpRepository { get; set; } = default!;
    
    private SignUpDto SignUpDto { get; set; } = new SignUpDto();
    
    private async Task SignUpUser()
    {
        await SignUpRepository.SignUp(SignUpDto);
    }
}