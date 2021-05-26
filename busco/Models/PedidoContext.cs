using Microsoft.EntityFrameworkCore;

namespace busco.Models
{
    public class PedidoContext : DbContext
    {

        public DbSet<Categoria> Categoria{get;set;}
        public DbSet<Cliente> Clientes{get;set;}


        public PedidoContext(DbContextOptions dco) : base(dco) {

        }
    }
}