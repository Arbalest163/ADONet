using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADonet.Db
{
    public class ContextFactory
    {
        public static VegetablesAndFruitsDbContext GetContext()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");
            var config = builder.Build();
            var connectionString = config.GetConnectionString("DbConnection");
            var options = new DbContextOptionsBuilder<VegetablesAndFruitsDbContext>()
                                .UseSqlServer(connectionString).Options;
            var context = new VegetablesAndFruitsDbContext(options);

            return context;
        }
    }
}
