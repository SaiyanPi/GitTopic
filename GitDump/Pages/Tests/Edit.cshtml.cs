using GitDump.Data;
using GitDump.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GitDump.Pages.Tests
{
    public class EditModel : PageModel
    {
        private readonly TestDbContext _context;
        [BindProperty]
        public Test Topic { get; set; }
        public EditModel(TestDbContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            Topic = _context.TestEntities.Find(id);
        }
        public async Task<IActionResult> OnPost()
        { 
            if (ModelState.IsValid) // server side validation
            {
                _context.TestEntities.Update(Topic);
                await _context.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
