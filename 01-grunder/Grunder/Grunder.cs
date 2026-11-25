namespace Grunder;

/// <summary>
/// Här skriver du din kod. Ändra bara i den här filen.
///
/// Byt ut raden "throw new NotImplementedException();" mot din egen kod
/// i en metod i taget. Kör testerna efter varje uppgift.
///
/// REGEL: Använd if-satser och loopar. Du får INTE använda färdiga
/// hjälpmetoder som Math.Max(), Math.Min(), .Sum(), .Max(), .Min(),
/// .Average(), .Count() eller Array.Reverse().
/// </summary>
public static class Ovningar
{
    // =====================================================================
    // DEL 1: VILLKOR (if / else)
    // =====================================================================

    /// <summary>
    /// UPPGIFT 1
    /// Returnera det största av de två talen.
    ///
    /// Exempel:  StorstAvTva(3, 8)  ->  8
    ///           StorstAvTva(5, 5)  ->  5
    /// </summary>
    public static int StorstAvTva(int a, int b)
    {
        // Skriv din kod här
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 2
    /// Returnera true om talet är jämnt, annars false.
    ///
    /// Exempel:  ArJamnt(4)  ->  true
    ///           ArJamnt(7)  ->  false
    ///
    /// Tips: operatorn % ger resten vid division. 7 % 2 blir 1.
    /// </summary>
    public static bool ArJamnt(int tal)
    {
        // Skriv din kod här
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 3
    /// Returnera betyget som en sträng utifrån poängen (0–100):
    ///
    ///   90–100  ->  "A"
    ///   80–89   ->  "B"
    ///   70–79   ->  "C"
    ///   60–69   ->  "D"
    ///   50–59   ->  "E"
    ///   0–49    ->  "F"
    ///
    /// Exempel:  Betyg(85)  ->  "B"
    ///
    /// Tips: använd if, else if och else.
    /// </summary>
    public static string Betyg(int poang)
    {
        // Skriv din kod här
        throw new NotImplementedException();
    }

    // =====================================================================
    // DEL 2: LOOPAR (for / while)
    // =====================================================================

    /// <summary>
    /// UPPGIFT 4
    /// Returnera summan av alla heltal från 1 till och med n.
    ///
    /// Exempel:  SummaUppTill(4)  ->  10   (1 + 2 + 3 + 4)
    ///           SummaUppTill(0)  ->  0
    /// </summary>
    public static int SummaUppTill(int n)
    {
        // Skriv din kod här
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 5
    /// Returnera hur många av talen från 1 till och med n som är jämna.
    ///
    /// Exempel:  AntalJamnaUppTill(10)  ->  5   (2, 4, 6, 8, 10)
    ///
    /// Tips: du kan använda din metod ArJamnt från uppgift 2.
    /// </summary>
    public static int AntalJamnaUppTill(int n)
    {
        // Skriv din kod här
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 6
    /// Returnera en array med de 10 första talen i multiplikationstabellen.
    ///
    /// Exempel:  Gangertabell(3)  ->  [3, 6, 9, 12, 15, 18, 21, 24, 27, 30]
    ///
    /// Tips: skapa arrayen med  int[] tabell = new int[10];
    /// </summary>
    public static int[] Gangertabell(int tal)
    {
        // Skriv din kod här
        throw new NotImplementedException();
    }

    // =====================================================================
    // DEL 3: ARRAYER
    // =====================================================================

    /// <summary>
    /// UPPGIFT 7
    /// Returnera summan av alla tal i arrayen.
    ///
    /// Exempel:  Summa([2, 5, 1])  ->  8
    ///           Summa([])         ->  0
    /// </summary>
    public static int Summa(int[] tal)
    {
        // Skriv din kod här
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 8
    /// Returnera det största talet i arrayen.
    /// Arrayen innehåller alltid minst ett tal.
    ///
    /// Exempel:  Storsta([4, 9, 2])     ->  9
    ///           Storsta([-5, -2, -8])  ->  -2
    ///
    /// Tips: börja med att anta att det första talet är störst.
    /// </summary>
    public static int Storsta(int[] tal)
    {
        // Skriv din kod här
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 9
    /// Returnera hur många tal i arrayen som är större än gransen.
    ///
    /// Exempel:  AntalStorreAn([3, 8, 1, 9, 5], 4)  ->  3   (8, 9 och 5)
    /// </summary>
    public static int AntalStorreAn(int[] tal, int grans)
    {
        // Skriv din kod här
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 10
    /// Returnera medelvärdet av talen i arrayen. En tom array ger 0.
    ///
    /// Exempel:  Medelvarde([1, 2])     ->  1.5
    ///           Medelvarde([2, 4, 6])  ->  4.0
    ///
    /// Se upp: 3 / 2 blir 1 i C# eftersom båda är heltal.
    /// Gör om summan till double först:  (double)summa / antal
    /// </summary>
    public static double Medelvarde(int[] tal)
    {
        // Skriv din kod här
        throw new NotImplementedException();
    }

    /// <summary>
    /// UPPGIFT 11 (utmaning)
    /// Returnera en NY array med talen i omvänd ordning.
    /// Originalarrayen får inte ändras.
    ///
    /// Exempel:  Vand([1, 2, 3])  ->  [3, 2, 1]
    ///
    /// Tips: skapa en ny array med samma längd: new int[tal.Length]
    /// </summary>
    public static int[] Vand(int[] tal)
    {
        // Skriv din kod här
        throw new NotImplementedException();
    }
}
