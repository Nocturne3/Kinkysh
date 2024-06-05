namespace Kinkysh.Components.Pages;

public partial class Explore
{
    private int CurrentPage { get; set; } = 1;
    
    private int PageSize { get; set; } = 6;
    
    private int TotalPages { get; set; }
    
    private async Task ChangePage(int page)
    {
        CurrentPage = page;
        await LoadUsers();
    }
}