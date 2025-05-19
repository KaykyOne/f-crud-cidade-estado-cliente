using CrudEstadoCidadeUsuario.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudEstadoCidadeUsuario.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Estado> Estado { get; set; }
    public DbSet<Cidade> Cidade { get; set; }
    public DbSet<Cliente> Cliente { get; set; }
}
