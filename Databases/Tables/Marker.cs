namespace Gruppe6Oppgave1.Web.Databases.Tables
{
    public class Marker
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Lattitude { get; set; }
        public int Longitude { get; set; }
        public int Altitude { get; set; }
    }
}
