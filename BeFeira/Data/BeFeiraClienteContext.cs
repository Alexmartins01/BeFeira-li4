using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeFeira.Models;

namespace BeFeira.Data
{
    public class BeFeiraClienteContext : DbContext
    {
        public BeFeiraClienteContext (DbContextOptions<BeFeiraClienteContext> options)
            : base(options)
        {
        }

        public DbSet<BeFeira.Models.Cliente> Cliente { get; set; } = default!;
    }
}
