using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InsuranceApplication.Areas.InsuranceApplication.Pages
{
    public class ContactInfoModel : PageModel
    {
        [BindProperty]
        public string EmailAddress { get; set; }

        public IActionResult OnPostAsync()
        {
            Console.WriteLine($"Email Address is {this.EmailAddress}.");
            return RedirectToPage("./InsuranceSelection");
        }
    }
}
