using Microsoft.EntityFrameworkCore;

namespace Crud8.Models
{
    public class BancoDeDados :DbContext
    {
            public DbSet<Funcionario> Funcionario { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Crud8;Integrated Security=True");
        }

    }
}
