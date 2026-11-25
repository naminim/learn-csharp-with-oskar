# Övning 02: Sortera en lista

Du ska skriva egna metoder som kontrollerar och sorterar listor med heltal.

**Här skriver du din kod:** [`SorteraLista/Sortering.cs`](SorteraLista/Sortering.cs)

## Regel
Du får **inte** använda inbyggd sortering, till exempel `lista.Sort()`,
`OrderBy()`, `Order()` eller `Array.Sort()`. Du ska skriva sorteringen
själv med loopar. Ett av testerna kontrollerar detta.

## Uppgifter

### Uppgift 1: `ArSorterad` (uppvärmning)
Returnera `true` om listan är sorterad i stigande ordning, annars `false`.

| In | Ut |
|---|---|
| `[1, 2, 2, 5]` | `true` |
| `[3, 1, 2]` | `false` |
| `[]` | `true` |

*Tips:* jämför varje tal med talet efter.

### Uppgift 2: `SorteraStigande`
Returnera en **ny** lista med talen sorterade från minst till störst.
Originallistan får inte ändras.

| In | Ut |
|---|---|
| `[5, 3, 8, 1]` | `[1, 3, 5, 8]` |

*Tips:* börja med att kopiera listan:
```csharp
var kopia = new List<int>(lista);
```
Sortera sedan kopian med **bubbelsortering**: gå igenom listan och byt plats
på två tal som står bredvid varandra om de står i fel ordning. Upprepa tills
inget behöver bytas.

Två tal kan byta plats så här:
```csharp
(kopia[i], kopia[i + 1]) = (kopia[i + 1], kopia[i]);
```

### Uppgift 3: `SorteraFallande`
Som uppgift 2, men från störst till minst.

| In | Ut |
|---|---|
| `[5, 3, 8, 1]` | `[8, 5, 3, 1]` |

## Testerna
Det finns 18 tester: 5 för uppgift 1, 7 för uppgift 2, 5 för uppgift 3
och 1 som kontrollerar regeln. Du ser resultatet under fliken **Actions**
i din fork efter varje push.
