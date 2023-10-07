using Microsoft.EntityFrameworkCore;
using Parcial2_MosqueraRosalesEdinson.DAL.Entities;

namespace Parcial2_MosqueraRosalesEdinson.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext>options) : base(options)
        {
            
        }

        public DbSet<NaturalPerson> NaturalsPersons { get; set; }


    }
}
