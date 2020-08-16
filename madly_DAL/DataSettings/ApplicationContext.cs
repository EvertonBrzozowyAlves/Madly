using Microsoft.EntityFrameworkCore;
using madly_models;


namespace madly_DAL.DataSettings
{
    public class MadlyContext : DbContext
    {
        public DbSet<Annotation> Annotations { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Para cadastrar a string de conexão com o banco de dados
        {
            optionsBuilder.UseSqlServer(ConnectionStrings.SqlServerDocker);
        }
    }
}
