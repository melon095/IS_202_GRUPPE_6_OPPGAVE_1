namespace Gruppe6Oppgave1.Web.Models
{
    
    public class GetAllReportsModel // Klasse for å hente alle rapporter fra databasencontrolleren
    {
        // Lage liste for rapprtene
        public List<MakeReportList> Reports { get; set; } = [];
        // Konstruktør
        public class MakeReportList // Klasse for å lage rapporter
        {
            public string Navn { get; set; } // Navn på objektet
            public string Beskrivelse { get; set; } // Beskrivelse av objektet
            public double Lattitude { get; set; } // Breddegrad
            public double Longitude { get; set; } // Lengdegrad
            public int Altitude { get; set; } // Høyde over havet
        }
    }
}
