using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SnapDeckInC_.Data;
using SnapDeckInC_.Models;

namespace SnapDeckInC_.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly SnapDeckInC_.Data.SnapDeckInC_Context _context;

        public DetailsModel(SnapDeckInC_.Data.SnapDeckInC_Context context)
        {
            _context = context;
        }

        public Card Card { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var card = await _context.Card.FirstOrDefaultAsync(m => m.Id == id);
            if (card == null)
            {
                return NotFound();
            }
            else
            {
                Card = card;
            }
            return Page();
        }
    }
}
