using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Internship_Azure_Cipher2.Pages;

public class ProductModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public ProductModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

