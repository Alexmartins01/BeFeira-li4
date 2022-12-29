using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeFeira.Models;

namespace BeFeira.Data
{
    public class BeFeiraPromocaoContext : DbContext
    {
        public BeFeiraPromocaoContext (DbContextOptions<BeFeiraPromocaoContext> options)
            : base(options)
        {
        }

        public DbSet<BeFeira.Models.Promocao> Promocao { get; set; } = default!;
    }
}
