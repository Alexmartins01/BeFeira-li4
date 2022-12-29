using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeFeira.Models;

namespace BeFeira.Data
{
    public class BeFeiraVendaProdutoContext : DbContext
    {
        public BeFeiraVendaProdutoContext (DbContextOptions<BeFeiraVendaProdutoContext> options)
            : base(options)
        {
        }

        public DbSet<BeFeira.Models.VendaProduto> VendaProduto { get; set; } = default!;
    }
}
