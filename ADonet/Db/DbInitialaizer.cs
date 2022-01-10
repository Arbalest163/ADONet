using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADonet.Db
{
    public class DbInitialaizer
    {
        public static void Initialaize(VegetablesAndFruitsDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
