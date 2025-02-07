using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiproWebApp1.Model;

namespace WiproWebApp1.Pages
{
    public class IndexRazorModel : PageModel
    {
        [BindProperty]
        public Employee emp { get; set; } = new Employee();
        public void OnGet()
        { 

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ViewData["Message"] = $"hello: {emp.EmpName}";
            return Page();
        }
    }
}
