using Kinkysh.Data.Models.User;
using Kinkysh.Data.Repositories.User;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Kinkysh.Components.Pages;

public partial class UserProfile
{
    private const int TempUserId = 8;
    
    private bool IsDrawerOpen { get; set; }

    private Anchor Anchor { get; set; }
    
    private PrivateUserDto UserDao { get; set; } = new();
    
    [Inject]
    private IUserRepository UserRepository { get; set; } = default!;

    protected override async Task OnInitializedAsync()
    {
        UserDao = await UserRepository.GetPrivateUserById(8);
    }
    
    private void OpenDrawer(Anchor anchor)
    {
        IsDrawerOpen = true;
        this.Anchor = anchor;
    }
}