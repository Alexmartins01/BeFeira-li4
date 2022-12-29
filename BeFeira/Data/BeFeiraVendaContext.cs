using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeFeira.Models;

namespace BeFeira.Data
{
    public class BeFeiraVendaContext : DbContext
    {
        public BeFeiraVendaContext (DbContextOptions<BeFeiraVendaContext> options)
            : base(options)
        {
        }

        public DbSet<BeFeira.Models.Venda> Venda { get; set; } = default!;
    }
}
