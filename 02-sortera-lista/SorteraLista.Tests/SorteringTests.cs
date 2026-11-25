using System.Text.RegularExpressions;
using SorteraLista;

namespace SorteraLista.Tests;

// ÄNDRA INTE I DEN HÄR FILEN.
// Testerna körs automatiskt i GitHub Actions varje gång du pushar.

public class Uppgift1_ArSorterad
{
    [Fact(DisplayName = "02 · Uppgift 1: Tom lista räknas som sorterad")]
    public void TomLista() =>
        Assert.True(Sortering.ArSorterad(new List<int>()));

    [Fact(DisplayName = "02 · Uppgift 1: Lista med ett tal räknas som sorterad")]
    public void EttTal() =>
        Assert.True(Sortering.ArSorterad(new List<int> { 7 }));

    [Fact(DisplayName = "02 · Uppgift 1: Sorterad lista ger true")]
    public void SorteradLista() =>
        Assert.True(Sortering.ArSorterad(new List<int> { -3, 0, 2, 2, 9 }));

    [Fact(DisplayName = "02 · Uppgift 1: Osorterad lista ger false")]
    public void OsorteradLista() =>
        Assert.False(Sortering.ArSorterad(new List<int> { 1, 2, 4, 3, 5 }));

    [Fact(DisplayName = "02 · Uppgift 1: Fel ordning i slutet upptäcks")]
    public void FelISlutet() =>
        Assert.False(Sortering.ArSorterad(new List<int> { 1, 2, 3, 4, 0 }));
}

public class Uppgift2_SorteraStigande
{
    [Fact(DisplayName = "02 · Uppgift 2: Sorterar en osorterad lista")]
    public void Osorterad() =>
        Assert.Equal(new List<int> { 1, 3, 5, 8 },
                     Sortering.SorteraStigande(new List<int> { 5, 3, 8, 1 }));

    [Fact(DisplayName = "02 · Uppgift 2: Tom lista ger tom lista")]
    public void TomLista() =>
        Assert.Empty(Sortering.SorteraStigande(new List<int>()));

    [Fact(DisplayName = "02 · Uppgift 2: Klarar dubbletter")]
    public void Dubbletter() =>
        Assert.Equal(new List<int> { 1, 2, 2, 2, 3 },
                     Sortering.SorteraStigande(new List<int> { 2, 3, 2, 1, 2 }));

    [Fact(DisplayName = "02 · Uppgift 2: Klarar negativa tal")]
    public void NegativaTal() =>
        Assert.Equal(new List<int> { -10, -1, 0, 4 },
                     Sortering.SorteraStigande(new List<int> { 0, -1, 4, -10 }));

    [Fact(DisplayName = "02 · Uppgift 2: Klarar en lista i omvänd ordning")]
    public void OmvandOrdning() =>
        Assert.Equal(new List<int> { 1, 2, 3, 4, 5, 6 },
                     Sortering.SorteraStigande(new List<int> { 6, 5, 4, 3, 2, 1 }));

    [Fact(DisplayName = "02 · Uppgift 2: Originallistan ändras inte")]
    public void AndrarInteOriginalet()
    {
        var original = new List<int> { 3, 1, 2 };
        Sortering.SorteraStigande(original);
        Assert.Equal(new List<int> { 3, 1, 2 }, original);
    }

    [Fact(DisplayName = "02 · Uppgift 2: Sorterar 500 slumpade tal rätt")]
    public void MangaSlumptal()
    {
        var slump = new Random(2026);
        var lista = Enumerable.Range(0, 500).Select(_ => slump.Next(-1000, 1000)).ToList();
        Assert.Equal(lista.OrderBy(x => x).ToList(), Sortering.SorteraStigande(lista));
    }
}

public class Uppgift3_SorteraFallande
{
    [Fact(DisplayName = "02 · Uppgift 3: Sorterar en osorterad lista")]
    public void Osorterad() =>
        Assert.Equal(new List<int> { 8, 5, 3, 1 },
                     Sortering.SorteraFallande(new List<int> { 5, 3, 8, 1 }));

    [Fact(DisplayName = "02 · Uppgift 3: Tom lista ger tom lista")]
    public void TomLista() =>
        Assert.Empty(Sortering.SorteraFallande(new List<int>()));

    [Fact(DisplayName = "02 · Uppgift 3: Klarar dubbletter och negativa tal")]
    public void DubbletterOchNegativa() =>
        Assert.Equal(new List<int> { 4, 4, 0, -2, -7 },
                     Sortering.SorteraFallande(new List<int> { -2, 4, -7, 0, 4 }));

    [Fact(DisplayName = "02 · Uppgift 3: Originallistan ändras inte")]
    public void AndrarInteOriginalet()
    {
        var original = new List<int> { 1, 3, 2 };
        Sortering.SorteraFallande(original);
        Assert.Equal(new List<int> { 1, 3, 2 }, original);
    }

    [Fact(DisplayName = "02 · Uppgift 3: Sorterar 500 slumpade tal rätt")]
    public void MangaSlumptal()
    {
        var slump = new Random(1337);
        var lista = Enumerable.Range(0, 500).Select(_ => slump.Next(-1000, 1000)).ToList();
        Assert.Equal(lista.OrderByDescending(x => x).ToList(), Sortering.SorteraFallande(lista));
    }
}

public class Regler
{
    [Fact(DisplayName = "02 · Regel: Ingen inbyggd sortering används i Sortering.cs")]
    public void IngenInbyggdSortering()
    {
        var kod = File.ReadAllText(HittaElevfilen());

        // Ta bort kommentarer så att det går att skriva om .Sort() i en kommentar.
        kod = Regex.Replace(kod, @"/\*.*?\*/", "", RegexOptions.Singleline);
        kod = Regex.Replace(kod, @"//.*", "");

        string[] forbjudet = { ".Sort(", "OrderBy", ".Order(", "Array.Sort", "SortedSet", "SortedList", "SortedDictionary", "OrderDescending(" };
        foreach (var ord in forbjudet)
        {
            Assert.False(kod.Contains(ord),
                $"Du använder '{ord}' i Sortering.cs. Skriv sorteringen själv med loopar i stället.");
        }
    }

    private static string HittaElevfilen()
    {
        var mapp = new DirectoryInfo(AppContext.BaseDirectory);
        while (mapp != null)
        {
            var fil = Path.Combine(mapp.FullName, "SorteraLista", "Sortering.cs");
            if (File.Exists(fil)) return fil;
            mapp = mapp.Parent;
        }
        throw new FileNotFoundException("Hittade inte SorteraLista/Sortering.cs");
    }
}
