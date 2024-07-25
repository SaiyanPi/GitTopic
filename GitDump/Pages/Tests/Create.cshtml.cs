using GitDump.Data;
using GitDump.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GitDump.Pages.Tests
{
    public class CreateModel : PageModel
    {
        private readonly TestDbContext _context;
        [BindProperty]
        public Test Topic { get; set; }
        public CreateModel(TestDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid) //server side validation
            {
                await _context.TestEntities.AddAsync(Topic);
                await _context.SaveChangesAsync();
                
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
