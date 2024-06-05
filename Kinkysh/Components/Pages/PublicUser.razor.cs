using Kinkysh.Data.Models.User;
using Kinkysh.Data.Repositories.User;
using Microsoft.AspNetCore.Components;

namespace Kinkysh.Components.Pages;

public partial class PublicUser
{
    [Parameter]
    public int UserId { get; set; }
    
    [Inject]
    private IUserRepository UserRepository { get; set; } = null!;
    
    private ExploreUserDto User { get; set; } = new();
    
    private async Task LoadUser()
    {
        User = await UserRepository.GetExploreUserById(UserId);
    }
    
    protected override async Task OnInitializedAsync()
    {
        await LoadUser();
    }
}