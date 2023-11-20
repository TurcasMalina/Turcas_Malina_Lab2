using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Turcas_Malina_Lab2.Models;

namespace Turcas_Malina_Lab2.Data
{
    public class Turcas_Malina_Lab2Context : DbContext
    {
        public Turcas_Malina_Lab2Context (DbContextOptions<Turcas_Malina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Turcas_Malina_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Turcas_Malina_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Turcas_Malina_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
