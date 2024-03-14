using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SnapDeckInC_.Models;

namespace SnapDeckInC_.Data
{
    public class SnapDeckInC_Context : DbContext
    {
        public SnapDeckInC_Context (DbContextOptions<SnapDeckInC_Context> options)
            : base(options)
        {
        }

        public DbSet<SnapDeckInC_.Models.Card> Card { get; set; } = default!;
    }
}
