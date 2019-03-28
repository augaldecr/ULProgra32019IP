using Microsoft.EntityFrameworkCore;
using PruebaAzure.Data.Entities;
namespace PruebaAzure.Data
{
    using Microsoft.EntityFrameworkCore;

    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<PruebaAzure.Data.Entities.Estudiante> Estudiante { get; set; }
    }
}
