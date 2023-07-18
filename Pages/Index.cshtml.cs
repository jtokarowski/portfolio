using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tokarowski_dev.Pages;

public class IndexModel : PageModel
{
    public List<PortfolioItem> PortfolioItems { get; set; }

    public void OnGet()
    {
        PortfolioItems = GetPortfolioItems(); // Method to retrieve your portfolio items
    }

    private List<PortfolioItem> GetPortfolioItems()
    {
        // Define and return a list of your portfolio items
        return new List<PortfolioItem>
        {
            new PortfolioItem { Title = "Music In Context (Sort My Spotify)", Url = "http://musicincontext.herokuapp.com/" },
            // new PortfolioItem { Title = "Project 2", Url = "https://example.com/project2" },
            // Add more portfolio items as needed
        };
    }
}

public class PortfolioItem
{
    public string Title { get; set; }
    public string Url { get; set; }
}