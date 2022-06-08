using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace Internship_Azure_Cipher2.Pages;

public class DemoModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public DemoModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public string Message {get; set;} = "Wacht op request...";


    public void OnGet()
    {
    
    }

    public void OnPostButtonClick(object sender, EventArgs e)
    {
        Message = DateTime.Now.ToString("HH:mm:ss - dd MMM yyyy", new System.Globalization.CultureInfo("nl-NL"));
        Console.WriteLine("[!] request is correct...");
    }
}