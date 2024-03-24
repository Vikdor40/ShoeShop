using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Magazin_za_obuvki.Models;

namespace Magazin_za_obuvki.Data
{
    public class Magazin_za_obuvkiContext : DbContext
    {
        public Magazin_za_obuvkiContext (DbContextOptions<Magazin_za_obuvkiContext> options)
            : base(options)
        {
        }

        public DbSet<Magazin_za_obuvki.Models.Client> Client { get; set; } = default!;
        public DbSet<Magazin_za_obuvki.Models.Shoe> Shoe { get; set; } = default!;
    }
}
