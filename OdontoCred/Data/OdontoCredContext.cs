using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OdontoCred.Models;

namespace OdontoCred.Data
{
    public class OdontoCredContext : DbContext
    {
        public OdontoCredContext (DbContextOptions<OdontoCredContext> options)
            : base(options)
        {
        }

        public DbSet<OdontoCred.Models.CadastroCliente> CadastroCliente { get; set; }
    }
}
