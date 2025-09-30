namespace Gruppe6Oppgave1.Web.Models
{
    // Sende data til view
    public class GetAllReportsModel
    {
        // Lage liste for rapprtene
        public List<MakeReportList> Reports { get; set; } = [];
        // Fra Marker tabellen har vi valgt Navn, Lattitude, Longitude og Altitude
        public class MakeReportList
        {
            public string Navn { get; set; }
            public double Lattitude { get; set; }
            public double Longitude { get; set; }
            public int Altitude { get; set; }
        }
    }
}
