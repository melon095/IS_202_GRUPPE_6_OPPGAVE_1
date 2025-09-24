namespace Gruppe6Oppgave1.Web.Models
{
    // Sende data til view
    public class GetAllReportsModel
    {
        // Lage liste for rapprtene
        public List<MakeReportList> Reports { get; set; } = [];
        // Konstruktør
        public class MakeReportList
        {
            public string Navn { get; set; }
            public int Lattitude { get; set; }
            public int Longitude { get; set; }
            public int Altitude { get; set; }
        }
    }
}
