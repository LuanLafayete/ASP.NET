using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Scaffold.Models;

namespace Scaffold.Data
{
    public class ScaffoldContext : DbContext
    {
        public ScaffoldContext (DbContextOptions<ScaffoldContext> options)
            : base(options)
        {
        }

        public DbSet<Scaffold.Models.Filme> Filme { get; set; } = default!;
    }
}
