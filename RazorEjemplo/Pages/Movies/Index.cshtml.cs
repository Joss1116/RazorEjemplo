using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorEjemplo.Data;
using RazorEjemplo.Models;

namespace RazorEjemplo.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorEjemplo.Data.RazorEjemploContext _context;

        public IndexModel(RazorEjemplo.Data.RazorEjemploContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
