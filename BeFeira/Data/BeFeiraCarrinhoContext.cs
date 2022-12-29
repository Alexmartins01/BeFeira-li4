using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeFeira.Models;

namespace BeFeira.Data
{
    public class BeFeiraCarrinhoContext : DbContext
    {
        public BeFeiraCarrinhoContext (DbContextOptions<BeFeiraCarrinhoContext> options)
            : base(options)
        {
        }

        public DbSet<BeFeira.Models.Carrinho> Carrinho { get; set; } = default!;
    }
}
