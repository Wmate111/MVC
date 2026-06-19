Katalog Filmów MVC

Autor: Mateusz Wielgat
Nr indeksu: 59866

Spis treści
Opis projektu
Technologie
Funkcjonalności
Struktura MVC
Instrukcja uruchomienia
Uwagi końcowe
1. Opis projektu

Projekt „Katalog Filmów MVC” został wykonany jako aplikacja zaliczeniowa z przedmiotu „Wzorzec MVC w tworzeniu aplikacji internetowych”.

Aplikacja służy do zarządzania prostą kolekcją filmów. Użytkownik może dodawać filmy, przeglądać ich listę, sprawdzać szczegóły, edytować dane oraz usuwać wybrane pozycje.

Projekt został wykonany w technologii ASP.NET Core MVC. Dane są zapisywane w lokalnej bazie SQLite.

2. Technologie

W projekcie wykorzystano:

ASP.NET Core MVC
C#
Entity Framework Core
SQLite
Bootstrap
HTML/CSS
Visual Studio
3. Funkcjonalności

Aplikacja posiada następujące funkcjonalności:

wyświetlanie listy filmów,
dodawanie nowego filmu,
podgląd szczegółów filmu,
edycja danych filmu,
usuwanie filmu,
wyszukiwanie po tytule, reżyserze i gatunku,
podstawowa walidacja danych w formularzach.

Formularz filmu zawiera pola: tytuł, reżyser, gatunek, rok produkcji, ocena oraz opis. Część pól jest wymagana, a ocena musi mieścić się w zakresie od 1 do 10.

4. Struktura MVC

Projekt wykorzystuje wzorzec MVC, czyli podział aplikacji na model, widoki i kontroler.

Model Film opisuje dane pojedynczego filmu. Zawiera między innymi tytuł, reżysera, gatunek, rok produkcji, ocenę oraz opis.

Widoki odpowiadają za prezentowanie danych użytkownikowi. W projekcie znajdują się widoki listy filmów, dodawania, edycji, szczegółów oraz usuwania.

Kontroler FilmsController obsługuje żądania użytkownika, pobiera dane z bazy, zapisuje zmiany i przekazuje dane do odpowiednich widoków.

5. Instrukcja uruchomienia

Aby uruchomić projekt, należy:

Sklonować repozytorium lub pobrać projekt na komputer.
Otworzyć projekt w Visual Studio.
Upewnić się, że zainstalowane są wymagane paczki NuGet:
Microsoft.EntityFrameworkCore.Sqlite
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.Design
W konsoli Package Manager Console wykonać polecenie:
Update-Database
Uruchomić projekt w Visual Studio, np. przez Ctrl + F5.

Po uruchomieniu aplikacji można przejść do zakładki „Filmy” i korzystać z katalogu.

6. Uwagi końcowe

Projekt pokazuje podstawowe działanie aplikacji internetowej wykonanej w architekturze MVC. Aplikacja zawiera operacje CRUD, czyli dodawanie, odczyt, edycję i usuwanie danych. Dodatkowo dodano prostą walidację oraz wyszukiwanie filmów.