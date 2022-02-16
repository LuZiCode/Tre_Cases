# Tre_Cases 
Tre Cases i en Solution Explorer med en main navigation menu, som der kræves adgang til via et brugernavn & adgangskode.

# Main Program (program.cs, static voic Main)
For at kunne få fat i navigationsmenuen, skal du oprette et brugernavn og en adgangskode

Dit brugernavn må ikke være tomt
Din adgangskode skal minimun være 12 karakterer lang
Din adgangskode skal minimun indebære 2 forskellige speciale karakterer
Din adgangskode skal minimun indebære 2 forskellige tal

Når du har oprettet en bruger gemmer den brugernavnet i tekstfilen under \Data\brugernavn.txt og adgangskoden i \Data\brugernavn.txt
Husk at ændre stigen i koden, så den passer til din mappes fil (Se program.cs på linje 50-52, 88 og 209)

Du har nu muligheden for at logge ind, ændre adgangskode eller oprette en bruger igen. (Filen kan kun håndtere en enkel bruger, så hvis du skriver et nyt login ind, så overskrider den det forrige login) 

# Navigation Menu (program.cs, internal void Run())
Inde i navigations menuen kan du vælge mellem 2 forskellige cases

(1) Fodbold menuen
(2) Dans menuen

# Fodbold Menu (fodbold.cs, internal void Run())
Denne menu bruges til at udregne hvordan fodboldsfans skal reagerer til en kamp ved hjælp af en string og en int. Stringen håndterer mål og inten håndterer afleveringer

Du vil blive spurgt om der er scoret et mål og hvor mange afleveringer der er lavet i kampen
Hvis der er 10 afleveriner eller derovre printer den "High Five - Jubel!!!"
Hvis der er mindre end 1 aflevering (0 afleveringer) printer den "Shh"
Hvis der er mellem 1-9 afleveringer printer den "Huh!" for hver aflevering
Hvis der er et mål, så overskrider den alle afleveringer muligheder og skriver "Olé Olé Olé"

(1) Eksempel på Input
Målinput: ingen mål
Afleveringerinput: 2 afleveringer

(1) Eksempel på Output
Output: Huh! Huh!

(2) Eksempel på Input
Målinput: mål
Afleveringerinput: 11 afleveringer

(2) Eksempel på Output
Output: Olé Olé Olé

(3) Eksempel på Input
Målinput: ingen mål
Afleveringerinput: 0 afleveringer

(3) Eksempel på Output
Output: Shh

# Dans Menu (dans.cs, internal void Run())
Denne menu bruges til at udregne to individuelles dansers point og navne, udregner pointene ved at ligge dem sammen.

Der vil blive spurgt om den første dansers navn og derefter personens point.
Efterfølgende spørges der indtil den anden danser navn og derefter personens point
som sagt nu vil pointene ligges sammen og udskrive begge navne og pointene nedenunder

(1) Eksempel på Input
Danser1input: tobias
Danser1point: 10 
Danser2input: thOmAs
Danser2point: 15

(2) Eksempel på Input
Dansersoutput: Tobias & Thomas
Pointoutput: 25


# Copyright © 2022, LuZiCode.
