namespace PruebaAzure.Data
{
    using Microsoft.EntityFrameworkCore;
    using PruebaAzure.Data.Entities;

    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Estudiante> Estudiante { get; set; }
    }
}
