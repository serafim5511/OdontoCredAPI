using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OdontoCred.Models
{
    public class Context : IdentityDbContext
    {
        public DbSet<CadastroCliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=OdontoCred;Integrated Security=True");
        }
    }
}
