using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeFeira.Models;

namespace BeFeira.Data
{
    public class BeFeiraFeiraContext : DbContext
    {
        public BeFeiraFeiraContext (DbContextOptions<BeFeiraFeiraContext> options)
            : base(options)
        {
        }

        public DbSet<BeFeira.Models.Feira> Feira { get; set; } = default!;
    }
}
