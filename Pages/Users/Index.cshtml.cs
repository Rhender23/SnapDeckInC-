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
    public class IndexModel : PageModel
    {
        private readonly SnapDeckInC_.Data.SnapDeckInC_Context _context;

        public IndexModel(SnapDeckInC_.Data.SnapDeckInC_Context context)
        {
            _context = context;
        }

        public IList<Card> Card { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Card = await _context.Card.ToListAsync();
        }
    }
}
