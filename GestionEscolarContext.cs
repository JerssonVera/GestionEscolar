using Microsoft.EntityFrameworkCore;

public class GestionEscolarContext(DbContextOptions<GestionEscolarContext> options) : DbContext(options)
{
    public DbSet<GestionEscolar.Models.Estudiante> Estudiante { get; set; } = default!;
}
