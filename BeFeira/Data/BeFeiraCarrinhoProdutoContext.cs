using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeFeira.Models;

namespace BeFeira.Data
{
    public class BeFeiraCarrinhoProdutoContext : DbContext
    {
        public BeFeiraCarrinhoProdutoContext (DbContextOptions<BeFeiraCarrinhoProdutoContext> options)
            : base(options)
        {
        }

        public DbSet<BeFeira.Models.CarrinhoProduto> CarrinhoProduto { get; set; } = default!;
    }
}
