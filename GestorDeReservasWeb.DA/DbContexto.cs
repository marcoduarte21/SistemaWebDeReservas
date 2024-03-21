using Microsoft.EntityFrameworkCore;

namespace GestorDeReservasWeb.DA
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options) 
        {
            
        }

        public DbSet<Model.People> Persona { get; set; }
        public DbSet<Model.Direccion> Direccion { get; set; }
        public DbSet<Model.Users> Provincia { get; set; }
        public DbSet<Model.Canton> Canton { get; set; }
        public DbSet<Model.Distrito> Distrito { get; set; }
        public DbSet<Model.Localidad> Localidad { get; set; }
        public DbSet<Model.Appoinments> Reservacion { get; set; }
        public DbSet<Model.TipoDeCita> TipoDeCita { get; set; }

    }
}