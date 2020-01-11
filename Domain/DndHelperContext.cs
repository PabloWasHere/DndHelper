using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DndHelperContext : DbContext
    {
        // "Server=192.168.1.75,12345;Database=DndHelper;User Id=runaid;Password=runaid;"
        public DndHelperContext() : base("Server=localhost,1433;Database=DndHelper;Integrated Security=SSPI;")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharClass> Classes { get; set; }
        public DbSet<Race> Races { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
