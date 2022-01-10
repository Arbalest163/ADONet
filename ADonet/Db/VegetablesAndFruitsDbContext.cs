using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADonet.Models;
using Microsoft.EntityFrameworkCore;

namespace ADonet.Db
{
    public class VegetablesAndFruitsDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public VegetablesAndFruitsDbContext
            (DbContextOptions<VegetablesAndFruitsDbContext> options)
                : base(options) { }
    }
}
