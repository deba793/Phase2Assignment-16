using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Phase2Assignment_16.Models;

namespace Phase2Assignment_16.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext (DbContextOptions<MovieDbContext> options)
            : base(options)
        {
        }

        public DbSet<Phase2Assignment_16.Models.Movie> Movie { get; set; } = default!;
    }
}
