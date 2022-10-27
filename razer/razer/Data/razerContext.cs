using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razer.Models;

namespace razer.Data
{
    public class razerContext : DbContext
    {
        public razerContext (DbContextOptions<razerContext> options)
            : base(options)
        {
        }

        public DbSet<razer.Models.Movie> Movie { get; set; } = default!;
    }
}
