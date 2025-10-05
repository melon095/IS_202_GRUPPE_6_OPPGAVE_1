Drift

Applikasjonen kan kjøres lokalt ved å starte prosjektet i Visual Studio.
Den kobler seg til en MariaDB Database der rapport tabellen blir skapt i Databases/Tables/Marker.cs
Databasen og tabellene opprettes og oppdateres automatisk ved hjelp av Entity Framework Core-migrasjoner.


Systemarkitektur

Databses:

Tables/Marker er tabellen i databasen som lagrer informasjonen om registrerte objekter.

DatabaseContext Klasse som kommuniserer mellom C# og databasen.

Models:

ObstacleData representerer hindringer som brukerne registrerer.

GetAllReportsModel brukes for å hente ut alle registrerte objekter til visning i admin-delen.

Controllers:

HomeController håndterer startsiden, registreringsskjemaet og oversiktsvisningen.

ObstacleController tar imot data fra skjemaet, godkjenner input og lagrer informasjonen i databasen.

AdminController henter alle registrerte objekter og viser dem i adminpanelet.

MapController sender view av kartet med alle registrerte objekter som markører.

Views:

DataForm er skjemaet der brukeren registrerer nye objekter.

Overview viser alle registrerte objekter i en liste.

Admin/Index viser alle registrerte objekter i tabellform for administratoren.


Database

Prosjektet bruker en DatabaseContext som inneholder en tabell for Marker. Denne brukes til å lagre objektene som brukerne registrerer.
Databasen oppdateres og vedlikeholdes gjennom migrasjoner i Entity Framework Core.
Tabellen inneholder feltene navn, beskrivelse, breddegrad, lengdegrad og høyde.

Test

Gyldig input: Når alle felter i skjemaet fylles ut korrekt, blir dataen lagret i databasen, og objektet vises både i oversikten og på kartet.
Ugyldig input: Hvis ett eller flere felt er tomme eller inneholder ugyldige verdier, vises det feilmeldinger, og dataen lagres ikke.
Admin-side: Viser alle registrerte objekter med korrekt navn, koordinater og høyde.
Kartvisning: Alle registrerte objekter vises som markører på kartet på riktig sted.
