# Aplikacja do Zarządzania Drużynami Piłkarskimi

Aplikacja desktopowa stworzona w Windows Forms napisana w języku C# 9.0.203 
z użyciem Frameworka Microsoft.EntityFrameworkCore, służąca do zarządzania:
- drużynami piłkarskimi
- kontraktami zawodników
- drużynami piłkarskimi
- tworzeniem wyników meczów.

### Zakładki aplikacji

1. **Teams**  
   - Wyświetlanie listy drużyn.  
   - Edytowanie i usuwanie istniejących drużyn.  
   - Dodawanie nowych drużyn przez formularz.  
   - Filtrowanie drużyn po dostępnych polach.

2. **Contracts**  
   - Zarządzanie kontraktami zawodników.  
   - Możliwość wyświetlania, edytowania i usuwania kontraktów.  
   - Dodawanie nowego kontraktu przez formularz.  
   - Filtrowanie rekordów kontraktów.

3. **Teams**  
   - Zarządzanie zespołami.  
   - Edytowanie, usuwanie i dodawanie zespołów.  
   - filtrowanie zespołów po różnych kryteriach.

4. **CreateGames**  
   - Tworzenie i zarządzanie wynikami meczów pomiędzy drużynami.  
   - Możliwość wprowadzania wyników spotkań.

---

## Technologia

- Język: **C# 9.0.203**
- ORM: **Entity Framework Core**
- Połączenie z bazą danych: konfigurowane poprzez plik `appsettings.json`
- DbContext: `AppDbContext`

## Instrukcja uruchomienia

1.Stwórz pustą bazę danych i załaduj plik sql.
2.Skonfiguruj połączenie do bazy danych w pliku appsettings.json.
3.Skompiluj projekt i uruchom aplikację.
4.Korzystaj z zakładek, aby zarządzać danymi (dodawanie, edycja, usuwanie, filtrowanie).

## Relacje w modelu danych

Poniżej opisano strukturę powiązań między encjami aplikacji:

### Team (Drużyna)
- **1:N z `Player`** – Jedna drużyna może mieć wielu zawodników, ale zawodnik należy tylko do jednej drużyny (`teamid`).
  - Usunięcie drużyny ustawia `teamid` zawodników na `NULL`.
- **1:N z `Match` jako gospodarze (`HomeMatches`)**
- **1:N z `Match` jako goście (`AwayMatches`)**
  - Usunięcie drużyny powoduje usunięcie powiązanych meczów (`Cascade`).

### Player (Zawodnik)
- **N:1 z `Team`** – Zawodnik należy do jednej drużyny.
- **1:1 z `PlayerContract`** – Każdy zawodnik może mieć dokładnie jeden kontrakt.
  - Klucz obcy: `PlayerContract.playerid`
  - Usunięcie zawodnika powoduje usunięcie powiązanego kontraktu (`Cascade`).

### PlayerContract (Kontrakt zawodnika)
- **1:1 z `Player`**
  - Klucz główny: `id`
  - Klucz unikalny: `playerid`

### Match (Mecz)
- **N:1 z `Team` jako gospodarze (`hometeamid`)**
- **N:1 z `Team` jako goście (`awayteamid`)**
  - Każdy mecz posiada dokładnie dwie drużyny: gospodarza i gościa.
  - Usunięcie jednej z drużyn powoduje usunięcie jej meczów (`Cascade`).
