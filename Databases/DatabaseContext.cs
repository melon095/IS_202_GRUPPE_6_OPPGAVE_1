using Gruppe6Oppgave1.Web.Databases.Tables;
using Microsoft.EntityFrameworkCore;

namespace Gruppe6Oppgave1.Web.Databases
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }
        public DbSet<Marker> Marker { get; set; }
    }
}
