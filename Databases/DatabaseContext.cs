using Gruppe6Oppgave1.Web.Databases.Tables;
using Microsoft.EntityFrameworkCore;

namespace Gruppe6Oppgave1.Web.Databases
{
    // Klasse DatabaseContext arver fra DbContext (Microsoft.EntityFrameworkCore)
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }
        public DbSet<Marker> Marker { get; set; }
    }
}
