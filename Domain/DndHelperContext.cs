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
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharClass> Classes { get; set; }
        public DbSet<Race> Races { get; set; }

        public DbSet<Spell> Spells { get; set; }
        public DbSet<CharacterPreparedSpell> CharacterPreparedSpells { get; set; }
        public DbSet<CharacterSpellbook> characterSpellbook { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));
            modelBuilder.Entity<CharacterPreparedSpell>().HasKey(ps => new { ps.CharacterId, ps.SpellId });
            modelBuilder.Entity<CharacterSpellbook>().HasKey(sb => new { sb.CharacterId, sb.SpellId });
        }
    }
}
