namespace Gruppe6Oppgave1.Web.Databases.Tables
{
    // Kolonnene for databasen
    public class Marker
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Lattitude { get; set; }
        public double Longitude { get; set; }
        public int Altitude { get; set; }
    }
}
