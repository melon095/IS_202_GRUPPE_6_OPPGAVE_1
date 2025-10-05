# Drift

Applikasjonen kan enten startes manuelt via Visual Studio, eller med docker ved bruk av kommando `docker compose up` i terminalen.
Den kobler seg til en MariaDB Database der rapport tabellen blir skapt fra Databases/Tables/Marker.cs
Databasen og tabellene opprettes og oppdateres automatisk ved hjelp av Entity Framework Core-migrasjoner.

# Systemarkitektur

## Databses

[Tables/Marker](https://github.com/melon095/IS_202_GRUPPE_6_OPPGAVE_1/blob/main/Databases/Tables/Marker.cs) er tabellen i databasen som lagrer informasjonen om registrerte objekter.

[DatabaseContext](https://github.com/melon095/IS_202_GRUPPE_6_OPPGAVE_1/blob/main/Databases/DatabaseContext.cs) Klasse som kommuniserer mellom C# og databasen.

## Models

[ObstacleData](https://github.com/melon095/IS_202_GRUPPE_6_OPPGAVE_1/blob/main/Models/ObstacleData.cs) representerer hindringer som brukerne registrerer.

[GetAllReportsModel](https://github.com/melon095/IS_202_GRUPPE_6_OPPGAVE_1/blob/main/Models/GetAllReportsModel.cs) brukes for å hente ut alle registrerte objekter til visning i admin-delen.

## Controllers

[HomeController](https://github.com/melon095/IS_202_GRUPPE_6_OPPGAVE_1/blob/main/Controllers/HomeController.cs) håndterer startsiden og oversiktsvisningen.

[ObstacleController](https://github.com/melon095/IS_202_GRUPPE_6_OPPGAVE_1/blob/main/Controllers/ObstacleController.cs) håndterer registreringsskjemaet, tar imot data fra skjemaet, godkjenner input og lagrer informasjonen i databasen.

[AdminController](https://github.com/melon095/IS_202_GRUPPE_6_OPPGAVE_1/blob/main/Controllers/AdminController.cs) henter alle registrerte objekter og viser dem i adminpanelet.

[MapController](https://github.com/melon095/IS_202_GRUPPE_6_OPPGAVE_1/blob/main/Controllers/MapController.cs) sender view av et kart.

## Views

[Obstacle/DataForm](https://github.com/melon095/IS_202_GRUPPE_6_OPPGAVE_1/blob/main/Views/Obstacle/DataForm.cshtml) er skjemaet der brukeren registrerer nye objekter.

[Obstacle/Overview](https://github.com/melon095/IS_202_GRUPPE_6_OPPGAVE_1/blob/main/Views/Obstacle/Overview.cshtml) viser det registrerte objektet samt kart.

[Admin/Index](https://github.com/melon095/IS_202_GRUPPE_6_OPPGAVE_1/blob/main/Views/Admin/Index.cshtml) viser alle registrerte objekter i tabellform for administratoren.

[Home/Index](https://github.com/melon095/IS_202_GRUPPE_6_OPPGAVE_1/blob/main/Views/Home/Index.cshtml) viser start siden.

[Map/Index](https://github.com/melon095/IS_202_GRUPPE_6_OPPGAVE_1/blob/main/Views/Map/Index.cshtml) viser et kart.

# Database

Applikasjonen bruker Entity Framework Core til abstraksjon av MariaDB database samt automatisk migrere database tabeller.

Dette blir brukt for å lagre og hente data fra MariaDB database.

[Tabellen](https://github.com/melon095/IS_202_GRUPPE_6_OPPGAVE_1/blob/main/Databases/Tables/Marker.cs) inneholder feltene ID (Primær Nøkkel), Navn, Beskrivelse, Breddegrad, Lengdegrad og Høyde.

# Test

Gyldig input: Når alle felter i skjemaet fylles ut korrekt, blir dataen lagret i databasen, og objektet vises både i oversikten og på kartet.
Ugyldig input: Hvis ett eller flere felt er tomme eller inneholder ugyldige verdier, vises det feilmeldinger, og dataen lagres ikke.
Admin-side: Viser alle registrerte objekter med korrekt navn, koordinater og høyde.
Kartvisning: Alle registrerte objekter vises som markører på kartet på riktig sted.
