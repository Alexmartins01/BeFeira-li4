using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeFeira.Models;

namespace BeFeira.Data
{
    public class BeFeiraStandContext : DbContext
    {
        public BeFeiraStandContext (DbContextOptions<BeFeiraStandContext> options)
            : base(options)
        {
        }

        public DbSet<BeFeira.Models.Stand> Stand { get; set; } = default!;
    }
}
