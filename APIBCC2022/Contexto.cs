using Microsoft.EntityFrameworkCore;

namespace APIBCC2022
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base (options) {}

        public DbSet<Produto> Produtos { get; set; }
    }
}
