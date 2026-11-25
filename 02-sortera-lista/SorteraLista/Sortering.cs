namespace SorteraLista;

/// <summary>
/// Här skriver du din kod. Ändra bara i den här filen.
///
/// REGEL: Du får INTE använda inbyggd sortering, till exempel
/// lista.Sort(), OrderBy(), Order() eller Array.Sort().
/// Du ska skriva sorteringen själv med loopar.
/// </summary>
public static class Sortering
{
    /// <summary>
    /// UPPGIFT 1 (uppvärmning)
    /// Returnera true om listan är sorterad i stigande ordning,
    /// annars false. En tom lista och en lista med ett tal räknas som sorterade.
    ///
    /// Exempel:
    ///   [1, 2, 2, 5]  ->  true
    ///   [3, 1, 2]     ->  false
    /// </summary>
    public static bool ArSorterad(List<int> lista)
    {
        // Skriv din kod här
        for (int i = 0; i < lista.Count - 1; i++)
        {
            if (lista[i] > lista[i + 1])
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// UPPGIFT 2
    /// Returnera en NY lista med samma tal sorterade i stigande ordning
    /// (minst först). Originallistan får inte ändras.
    ///
    /// Exempel:
    ///   [5, 3, 8, 1]  ->  [1, 3, 5, 8]
    ///
    /// Tips: Börja med att kopiera listan: var kopia = new List&lt;int&gt;(lista);
    /// Bubbelsortering är en bra algoritm att börja med.
    /// </summary>
    public static List<int> SorteraStigande(List<int> lista)
    {
        // Skriv din kod här
        var kopia = new List<int>(lista);
        for (int i = 0; i < kopia.Count - 1; i++)
        {
            for (int j = 0; j < kopia.Count - 1 - i; j++)
            {
                if (kopia[j] > kopia[j + 1])
                {
                    (kopia[j], kopia[j + 1]) = (kopia[j + 1], kopia[j]);
                }
            }
        }
        return kopia;
    }

    /// <summary>
    /// UPPGIFT 3
    /// Returnera en NY lista med samma tal sorterade i fallande ordning
    /// (störst först). Originallistan får inte ändras.
    ///
    /// Exempel:
    ///   [5, 3, 8, 1]  ->  [8, 5, 3, 1]
    /// </summary>
    public static List<int> SorteraFallande(List<int> lista)
    {
        // Skriv din kod här
        var kopia = new List<int>(lista);
        for (int i = 0; i < kopia.Count - 1; i++)
        {
            for (int j = 0; j < kopia.Count - 1 - i; j++)
            {
                if (kopia[j] < kopia[j + 1])
                {
                    (kopia[j], kopia[j + 1]) = (kopia[j + 1], kopia[j]);
                }
            }
        }
        return kopia;
    }
}
