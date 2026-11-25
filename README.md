# Lär dig C# med Oskar

Övningar i C# som rättas automatiskt. Du skriver koden, pushar till GitHub
och får direkt veta vilka tester som är godkända.

| Nr | Övning | Mapp |
|---|---|---|
| 01 | Grunder – villkor, loopar och arrayer | [`01-grunder`](01-grunder) |
| 02 | Sortera en lista | [`02-sortera-lista`](02-sortera-lista) |

---

## Kom igång (görs en gång)

### 1. Forka repot
Klicka på **Fork** uppe till höger och sedan på **Create fork**.
Kontrollera att det står **ditt-namn / learn-csharp-with-oskar** överst.

### 2. Slå på autorättningen
GitHub stänger av automatiska körningar i nya forkar.

1. Gå till fliken **Actions** i **din fork**.
2. Klicka på den gröna knappen **I understand my workflows, go ahead and enable them**.

Gör du inte det här steget händer ingenting när du pushar.

### 3. Klona din fork
Byt `DITT-NAMN` mot **ditt eget** GitHub-namn. Klona din fork, inte lärarens repo,
annars går det inte att pusha.
```bash
git clone https://github.com/DITT-NAMN/learn-csharp-with-oskar.git
cd learn-csharp-with-oskar
start learn-csharp-with-oskar.sln
```
Den sista raden öppnar övningarna i Visual Studio.

### 4. Koppla till lärarens repo
Då kan du hämta nya övningar när de kommer:
```bash
git remote add upstream https://github.com/OskarRayFrayssinet/learn-csharp-with-oskar.git
```

---

## Så jobbar du med en övning

1. Öppna övningens mapp och läs dess README.
2. Skriv din kod i den fil som README:n anger. **Ändra inte i testfilerna.**
   Kör testerna i Visual Studio med **Test → Run All Tests**.
   (Tryck inte på ▶ Start – övningarna är inga program som kan startas.)
3. Spara, committa och pusha:
   ```bash
   git add .
   git commit -m "Löste uppgift 1"
   git push
   ```
4. Gå till fliken **Actions** i din fork och klicka på den senaste körningen.
   Där ser du en tabell med alla tester:
   - ✅ = godkänt
   - ❌ = inte godkänt än

   På forkens startsida syns resultatet också som en grön bock ✓ eller ett rött kryss ✗
   bredvid din senaste commit.

Du kan pusha hur många gånger du vill. Varje push rättas på nytt.

### Testa på din egen dator (valfritt)
Har du .NET 10 SDK installerat kan du köra testerna innan du pushar:
```bash
dotnet test
```

---

## Hämta nya övningar från läraren

Committa alltid ditt eget arbete först, och hämta sedan:
```bash
git add .
git commit -m "Mitt arbete"
git pull --no-rebase --no-edit upstream main
git push
```

Står det `CONFLICT`: räck upp handen.
