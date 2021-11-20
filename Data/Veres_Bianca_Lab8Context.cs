using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Veres_Bianca_Lab8.Models;

namespace Veres_Bianca_Lab8.Data
{
    public class Veres_Bianca_Lab8Context : DbContext
    {
        public Veres_Bianca_Lab8Context (DbContextOptions<Veres_Bianca_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Veres_Bianca_Lab8.Models.Book> Book { get; set; }

        public DbSet<Veres_Bianca_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Veres_Bianca_Lab8.Models.Category> Category { get; set; }
    }
}
