using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace toode
{
    public class ToodeContext : DbContext
    {
        public DbSet<Toode> Tootetabel { get; set; }
        public DbSet<Kategooria> Kategooriatabel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=Tooded_DB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategooria>().ToTable("Kategooriatabel");
            modelBuilder.Entity<Toode>().ToTable("Tootetabel");
            modelBuilder.Entity<Toode>().Property(t => t.Lisatud).HasDefaultValueSql("GETDATE()");
        }
        public void EnsureCreated()
        {
            this.Database.EnsureCreated();
        }
    }
}
