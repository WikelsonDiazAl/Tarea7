using Microsoft.EntityFrameworkCore;

public class DetencionContexto : DbContext{

    public DbSet<Detencion> Detencion {get; set;}

    public DetencionContexto(DbContextOptions<DetencionContexto> options) : base(options)
    {
    }
}