using Microsoft.EntityFrameworkCore;

namespace sessions
{
    public class conect:DbContext
    {
        public DbSet<Studant> studants { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder db)
        {
            db.UseSqlServer("data source=.;initial catalog=scool;integrated security=true");
        }
    }
}