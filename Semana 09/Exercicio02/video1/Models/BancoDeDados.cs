using Microsoft.EntityFrameworkCore;

namespace video1.Models
{
    public class BancoDeDados:DbContext
    {
        public DbSet<Cliente> Clients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Crud;Integrated Security=True");
        }
    }
}
