using GitDump.Data;
using GitDump.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GitDump.Pages.Tests
{
  
    public class IndexModel : PageModel
    {
        private readonly TestDbContext _context;
        public IEnumerable<Test> Tests { get; set; }
        public IndexModel(TestDbContext context)
        {
            _context = context;
        }
        
        public void OnGet()
        {
            Tests = _context.TestEntities;
        }
    }
}
