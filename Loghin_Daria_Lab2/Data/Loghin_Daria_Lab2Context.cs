using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Loghin_Daria_Lab2.Models;

namespace Loghin_Daria_Lab2.Data
{
    public class Loghin_Daria_Lab2Context : DbContext
    {
        public Loghin_Daria_Lab2Context (DbContextOptions<Loghin_Daria_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Loghin_Daria_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Loghin_Daria_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
