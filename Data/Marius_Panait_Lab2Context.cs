using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Marius_Panait_Lab2.Models;

namespace Marius_Panait_Lab2.Data
{
    public class Marius_Panait_Lab2Context : DbContext
    {
        public Marius_Panait_Lab2Context (DbContextOptions<Marius_Panait_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Marius_Panait_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Marius_Panait_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Marius_Panait_Lab2.Models.Author>? Author { get; set; }
    }
}
