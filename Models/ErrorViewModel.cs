namespace Gruppe6Oppgave1.Web.Models;

public class ErrorViewModel // Definerer en modell for feilvisning, som heter ErrorViewModel
{
    public string? RequestId { get; set; } // Egenskap for å lagre RequestId, som kan være null

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId); // Egenskap som returnerer true hvis RequestId ikke er null eller tom
}