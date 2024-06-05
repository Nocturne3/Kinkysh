using System.Collections.ObjectModel;
using Kinkysh.Data.Models.User;
using Kinkysh.Data.Repositories.User;
using Microsoft.AspNetCore.Components;

namespace Kinkysh.Components.Pages;

public partial class Explore
{
    [Inject]
    private IUserRepository UserRepository { get; set; } = null!;
    
    private ObservableCollection<ExploreUserDto> Users { get; set; } = [];
    
    protected override async Task OnInitializedAsync()
    {
        await LoadUsers();
    }

    private async Task LoadUsers()
    {
        var response = await UserRepository.GetExploreUsers(CurrentPage, PageSize);
        Users = new ObservableCollection<ExploreUserDto>(response.users);
        TotalPages = response.totalPages;
        Console.WriteLine(TotalPages);
    }
}