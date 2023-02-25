using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorEjemplo.Models;

namespace RazorEjemplo.Data
{
    public class RazorEjemploContext : DbContext
    {
        public RazorEjemploContext (DbContextOptions<RazorEjemploContext> options)
            : base(options)
        {
        }

        public DbSet<RazorEjemplo.Models.Movie> Movie { get; set; } = default!;
    }
}
