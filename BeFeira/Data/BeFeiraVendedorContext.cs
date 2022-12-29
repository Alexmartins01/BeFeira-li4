using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeFeira.Models;

namespace BeFeira.Data
{
    public class BeFeiraVendedorContext : DbContext
    {
        public BeFeiraVendedorContext (DbContextOptions<BeFeiraVendedorContext> options)
            : base(options)
        {
        }

        public DbSet<BeFeira.Models.Vendedor> Vendedor { get; set; } = default!;
    }
}
