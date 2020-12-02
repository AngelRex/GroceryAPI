using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GroceryAPI.Data
{
    public class GroceryContext: DbContext
    {
            public GroceryContext(DbContextOptions<GroceryContext> opt) : base(opt)
            {

            }

            public DbSet<Grocery> Grocerys { get; set; }

        
    }
}
