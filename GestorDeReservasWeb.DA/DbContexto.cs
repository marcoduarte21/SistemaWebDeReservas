using Microsoft.EntityFrameworkCore;

namespace GestorDeReservasWeb.DA
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options) 
        {
            
        }

        public DbSet<Model.People> People { get; set; }
        public DbSet<Model.Appoinment> Appoinments { get; set; }
        public DbSet<Model.User> Users { get; set; }
        public DbSet<Model.Employee> Employees { get; set; }


    }
}