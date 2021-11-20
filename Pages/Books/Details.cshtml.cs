using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Veres_Bianca_Lab8.Data;
using Veres_Bianca_Lab8.Models;

namespace Veres_Bianca_Lab8.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Veres_Bianca_Lab8.Data.Veres_Bianca_Lab8Context _context;

        public DetailsModel(Veres_Bianca_Lab8.Data.Veres_Bianca_Lab8Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
