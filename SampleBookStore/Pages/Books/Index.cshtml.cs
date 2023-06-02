using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SampleBookStore.Models;

namespace SampleBookStore.Pages.Books {
    public class IndexModel : PageModel
    {
        private readonly SampleBookStore.Data.SampleBookStoreContext _context;

        public IndexModel(SampleBookStore.Data.SampleBookStoreContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Books != null)
            {
                Book = await _context.Books.ToListAsync();
            }
        }
    }
}
