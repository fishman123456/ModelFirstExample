using Microsoft.EntityFrameworkCore;

using ModelFirstExample.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Shambala_entity_17_10_2023_Game
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Menuitem> menuitems { get; set; }

        protected override  void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = fishman\SQLEXPRESS;
                                                Initial Catalog = menu_db;
                                                Integrated Security = SSPI;
                                                TrustServerCertificate = True");
        }
    }
}
