using GitDump.Data;
using GitDump.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GitDump.Pages.Tests
{
    public class DeleteModel : PageModel
    {
        private readonly TestDbContext _context;
        [BindProperty]
        public Test Topic { get; set; }
        public DeleteModel(TestDbContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            Topic = _context.TestEntities.Find(id);
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid) //server side validation
            {
                var topicFromDb = _context.TestEntities.Find(Topic.Id);
                if (topicFromDb != null)
                {
                    _context.TestEntities.Remove(topicFromDb);
                    await _context.SaveChangesAsync();

                    return RedirectToPage("Index");
                }
            }
            return Page();
        }
    }
}
