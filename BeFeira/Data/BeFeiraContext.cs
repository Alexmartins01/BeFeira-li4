using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeFeira.Models;

namespace BeFeira.Data
{
    public class BeFeiraContext : DbContext
    {
        public BeFeiraContext (DbContextOptions<BeFeiraContext> options)
            : base(options)
        {
        }

        public DbSet<BeFeira.Models.Administrador> Administrador { get; set; } = default!;
    }
}
