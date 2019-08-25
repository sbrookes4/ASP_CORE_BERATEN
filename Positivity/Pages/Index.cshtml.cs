using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Positivity.Pages
{
    public class IndexModel : PageModel
    {
        public IActionResult OnGet()
        {
            try
            {
                return RedirectToPage(Navigator.Login);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}