﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SampleBookStore.Models;

namespace SampleBookStore.Pages.Books {
    public class DetailsModel : PageModel
    {
        private readonly SampleBookStore.Data.SampleBookStoreContext _context;

        public DetailsModel(SampleBookStore.Data.SampleBookStoreContext context)
        {
            _context = context;
        }

      public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return NotFound();
            }

            var book = await _context.Books.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
