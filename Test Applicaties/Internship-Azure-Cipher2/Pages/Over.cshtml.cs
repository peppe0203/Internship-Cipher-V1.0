using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace Internship_Azure_Cipher2.Pages;

public class OverModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public OverModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
    
}
