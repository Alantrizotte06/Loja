using Microsoft.EntityFrameworkCore;
using Loja.data;

namespace Loja.data
{
  public class LojaDbContext : DbContext
  {
    public LojaDbContext(DbContextOptions<LojaDbContext> options) : base(options) { }
    public DbSet<ProducesResponseTypeMetadata> Produtos { get; set; }
  }
}