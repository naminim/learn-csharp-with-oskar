# Övning 01: Grunder – villkor, loopar och arrayer

Elva korta uppgifter som tränar grunderna i C#. Börja med uppgift 1 och
jobba dig nedåt. Varje uppgift är en egen metod.

**Här skriver du din kod:** [`Grunder/Grunder.cs`](Grunder/Grunder.cs)

## Så jobbar du
1. Öppna `Grunder.cs` och leta upp metoden för uppgiften.
2. Ta bort raden `throw new NotImplementedException();` och skriv din kod.
3. Kör testerna i **Test Explorer** (**Test → Run All Tests**).
   Testerna för just den uppgiften ska bli gröna.
4. Committa och pusha. Gå sedan vidare till nästa uppgift.

Det är helt okej att pusha efter varje uppgift. Då ser du hur antalet
gröna tester växer under fliken **Actions**.

## Regel
Lös uppgifterna med **if-satser och loopar**. Du får inte använda färdiga
hjälpmetoder som `Math.Max()`, `.Sum()`, `.Max()`, `.Min()`, `.Average()`,
`.Count()` eller `Array.Reverse()`. Ett av testerna kontrollerar detta.

## Del 1: Villkor

| Nr | Metod | Exempel |
|---|---|---|
| 1 | `StorstAvTva(a, b)` | `StorstAvTva(3, 8)` → `8` |
| 2 | `ArJamnt(tal)` | `ArJamnt(4)` → `true` |
| 3 | `Betyg(poang)` | `Betyg(85)` → `"B"` |

Påminnelse om if-satser:
```csharp
if (tal > 10)
{
    // körs om villkoret är sant
}
else if (tal > 5)
{
    // körs om första villkoret är falskt men detta är sant
}
else
{
    // körs annars
}
```

## Del 2: Loopar

| Nr | Metod | Exempel |
|---|---|---|
| 4 | `SummaUppTill(n)` | `SummaUppTill(4)` → `10` |
| 5 | `AntalJamnaUppTill(n)` | `AntalJamnaUppTill(10)` → `5` |
| 6 | `Gangertabell(tal)` | `Gangertabell(3)` → `[3, 6, 9, … 30]` |

Påminnelse om for-loopen:
```csharp
for (int i = 1; i <= 5; i++)
{
    // körs fem gånger, med i = 1, 2, 3, 4, 5
}
```

## Del 3: Arrayer

| Nr | Metod | Exempel |
|---|---|---|
| 7 | `Summa(tal)` | `Summa([2, 5, 1])` → `8` |
| 8 | `Storsta(tal)` | `Storsta([4, 9, 2])` → `9` |
| 9 | `AntalStorreAn(tal, grans)` | `AntalStorreAn([3, 8, 1, 9, 5], 4)` → `3` |
| 10 | `Medelvarde(tal)` | `Medelvarde([1, 2])` → `1.5` |
| 11 | `Vand(tal)` *(utmaning)* | `Vand([1, 2, 3])` → `[3, 2, 1]` |

Påminnelse om arrayer:
```csharp
int[] tal = { 4, 9, 2 };

tal.Length    // antal tal i arrayen: 3
tal[0]        // första talet: 4
tal[tal.Length - 1]   // sista talet: 2

for (int i = 0; i < tal.Length; i++)
{
    // tal[i] är talet på plats i
}
```

## Testerna
Det finns 30 tester. De har namn som börjar med `01 · Uppgift X`, så att du
ser vilken uppgift som är klar.
