using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppMovie.Models;

namespace AppMovie.Data
{
    public class AppMovieContext : DbContext
    {
        public AppMovieContext (DbContextOptions<AppMovieContext> options)
            : base(options)
        {
        }

        public DbSet<AppMovie.Models.Movie> Movie { get; set; } = default!;
        public DbSet<AppMovie.Models.User> User { get; set; } = default!;
    }
}
