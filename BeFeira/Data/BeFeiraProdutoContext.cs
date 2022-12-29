using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeFeira.Models;

namespace BeFeira.Data
{
    public class BeFeiraProdutoContext : DbContext
    {
        public BeFeiraProdutoContext (DbContextOptions<BeFeiraProdutoContext> options)
            : base(options)
        {
        }

        public DbSet<BeFeira.Models.Produto> Produto { get; set; } = default!;
    }
}
