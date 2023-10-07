using Microsoft.EntityFrameworkCore;
using Parcial2_MosqueraRosalesEdinson.DAL.Entities;

namespace Parcial2_MosqueraRosalesEdinson.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext>options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<NaturalPerson>().HasIndex(c =>c.FullName).IsUnique();
            modelBuilder.Entity<NaturalPerson>().HasIndex(c =>c.Email).IsUnique();
        }

        public DbSet<NaturalPerson> NaturalsPersons { get; set; }


    }
}
