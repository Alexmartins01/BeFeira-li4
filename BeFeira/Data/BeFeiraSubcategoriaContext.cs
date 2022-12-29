using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeFeira.Models;

namespace BeFeira.Data
{
    public class BeFeiraSubcategoriaContext : DbContext
    {
        public BeFeiraSubcategoriaContext (DbContextOptions<BeFeiraSubcategoriaContext> options)
            : base(options)
        {
        }

        public DbSet<BeFeira.Models.Subcategoria> Subcategoria { get; set; } = default!;
    }
}
