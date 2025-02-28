namespace P01DAW__2022MM652_2022AR652__Reservas.data;
using Microsoft.EntityFrameworkCore;
using P01DAW__2022MM652_2022AR652__Reservas.Models;


public class ReservasContext : DbContext
{
    public ReservasContext(DbContextOptions<ReservasContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Sucursal> Sucursales { get; set; }
    public DbSet<EspacioParqueo> EspaciosParqueo { get; set; }
    public DbSet<Reserva> Reservas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>()
            .HasOne<Sucursal>()
            .WithMany()
            .HasForeignKey(u => u.SucursalId);

        modelBuilder.Entity<EspacioParqueo>()
            .HasOne<Sucursal>()
            .WithMany()
            .HasForeignKey(e => e.SucursalId);

        modelBuilder.Entity<Reserva>()
            .HasOne<Usuario>()
            .WithMany()
            .HasForeignKey(r => r.UsuarioId);

        modelBuilder.Entity<Reserva>()
            .HasOne<EspacioParqueo>()
            .WithMany()
            .HasForeignKey(r => r.EspacioId);
    }
}
