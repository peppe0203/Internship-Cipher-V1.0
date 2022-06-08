using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace Internship_Azure_Cipher2.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        string dateTime = DateTime.Now.ToString("d", new CultureInfo("nl-nl"));
        ViewData["TimeStamp"] = dateTime;
    }
    
}
