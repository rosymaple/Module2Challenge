using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module2Challenge.Pages;


public class IndexModel : PageModel
{
    [BindProperty]
    public decimal Miles {get;set;}
    [BindProperty]
    public decimal Gallons {get;set;}
    public decimal MPG {get;set;}

// post request for submit button
// MPG and UpperCase follows C# PascalCase naming conventions
// [BindProperty] binding values from view to model 
// {get;set;} auto-implemented properties

    public void OnPost()
    {
        if (Gallons > 0)
        {
        MPG = Miles / Gallons;
        }
    }
}





