using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AppMovie.Data;
using AppMovie.Models;

namespace AppMovie.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly AppMovie.Data.AppMovieContext _context;

        public IndexModel(AppMovie.Data.AppMovieContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
