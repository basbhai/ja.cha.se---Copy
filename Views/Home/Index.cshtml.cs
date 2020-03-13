using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ja.cha.se.Views.Home
{
    public class Index1Model : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (Username.Equals("basbhai") && Password.Equals("Iambasbhai@021"))
            {
               
                return RedirectToPage("Privacy");

            }
            else
            {
                
                return Page();
            }
        }
    }
}
