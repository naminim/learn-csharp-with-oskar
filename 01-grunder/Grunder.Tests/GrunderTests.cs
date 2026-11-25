using System.Text.RegularExpressions;
using Grunder;

namespace Grunder.Tests;

// ÄNDRA INTE I DEN HÄR FILEN.
// Testerna körs automatiskt i GitHub Actions varje gång du pushar.

public class Del1_Villkor
{
    [Fact(DisplayName = "01 · Uppgift 1: StorstAvTva – första talet störst")]
    public void ForstaStorst() => Assert.Equal(9, Ovningar.StorstAvTva(9, 4));

    [Fact(DisplayName = "01 · Uppgift 1: StorstAvTva – andra talet störst")]
    public void AndraStorst() => Assert.Equal(8, Ovningar.StorstAvTva(3, 8));

    [Fact(DisplayName = "01 · Uppgift 1: StorstAvTva – lika stora och negativa tal")]
    public void LikaOchNegativa()
    {
        Assert.Equal(5, Ovningar.StorstAvTva(5, 5));
        Assert.Equal(-2, Ovningar.StorstAvTva(-7, -2));
    }

    [Fact(DisplayName = "01 · Uppgift 2: ArJamnt – jämna tal ger true")]
    public void JamnaTal()
    {
        Assert.True(Ovningar.ArJamnt(4));
        Assert.True(Ovningar.ArJamnt(0));
        Assert.True(Ovningar.ArJamnt(-6));
    }

    [Fact(DisplayName = "01 · Uppgift 2: ArJamnt – udda tal ger false")]
    public void UddaTal()
    {
        Assert.False(Ovningar.ArJamnt(7));
        Assert.False(Ovningar.ArJamnt(1));
        Assert.False(Ovningar.ArJamnt(-3));
    }

    [Fact(DisplayName = "01 · Uppgift 3: Betyg – mitt i varje intervall")]
    public void MittIIntervallen()
    {
        Assert.Equal("A", Ovningar.Betyg(95));
        Assert.Equal("B", Ovningar.Betyg(85));
        Assert.Equal("C", Ovningar.Betyg(75));
        Assert.Equal("D", Ovningar.Betyg(65));
        Assert.Equal("E", Ovningar.Betyg(55));
        Assert.Equal("F", Ovningar.Betyg(20));
    }

    [Fact(DisplayName = "01 · Uppgift 3: Betyg – precis på gränserna")]
    public void PaGranserna()
    {
        Assert.Equal("A", Ovningar.Betyg(90));
        Assert.Equal("A", Ovningar.Betyg(100));
        Assert.Equal("B", Ovningar.Betyg(89));
        Assert.Equal("B", Ovningar.Betyg(80));
        Assert.Equal("C", Ovningar.Betyg(70));
        Assert.Equal("D", Ovningar.Betyg(60));
        Assert.Equal("E", Ovningar.Betyg(50));
        Assert.Equal("F", Ovningar.Betyg(49));
        Assert.Equal("F", Ovningar.Betyg(0));
    }
}

public class Del2_Loopar
{
    [Fact(DisplayName = "01 · Uppgift 4: SummaUppTill – små tal")]
    public void SmaTal()
    {
        Assert.Equal(1, Ovningar.SummaUppTill(1));
        Assert.Equal(10, Ovningar.SummaUppTill(4));
    }

    [Fact(DisplayName = "01 · Uppgift 4: SummaUppTill – 0 ger 0")]
    public void Noll() => Assert.Equal(0, Ovningar.SummaUppTill(0));

    [Fact(DisplayName = "01 · Uppgift 4: SummaUppTill – 100 ger 5050")]
    public void Hundra() => Assert.Equal(5050, Ovningar.SummaUppTill(100));

    [Fact(DisplayName = "01 · Uppgift 5: AntalJamnaUppTill – 10 ger 5")]
    public void Tio() => Assert.Equal(5, Ovningar.AntalJamnaUppTill(10));

    [Fact(DisplayName = "01 · Uppgift 5: AntalJamnaUppTill – udda gräns och 1")]
    public void UddaGrans()
    {
        Assert.Equal(3, Ovningar.AntalJamnaUppTill(7));
        Assert.Equal(0, Ovningar.AntalJamnaUppTill(1));
    }

    [Fact(DisplayName = "01 · Uppgift 6: Gangertabell – 3:ans tabell")]
    public void Treans() =>
        Assert.Equal(new[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 }, Ovningar.Gangertabell(3));

    [Fact(DisplayName = "01 · Uppgift 6: Gangertabell – 7:ans tabell")]
    public void Sjuans() =>
        Assert.Equal(new[] { 7, 14, 21, 28, 35, 42, 49, 56, 63, 70 }, Ovningar.Gangertabell(7));
}

public class Del3_Arrayer
{
    [Fact(DisplayName = "01 · Uppgift 7: Summa – vanlig array")]
    public void SummaVanlig() => Assert.Equal(8, Ovningar.Summa(new[] { 2, 5, 1 }));

    [Fact(DisplayName = "01 · Uppgift 7: Summa – tom array ger 0")]
    public void SummaTom() => Assert.Equal(0, Ovningar.Summa(new int[0]));

    [Fact(DisplayName = "01 · Uppgift 7: Summa – negativa tal")]
    public void SummaNegativa() => Assert.Equal(-4, Ovningar.Summa(new[] { 3, -10, 3 }));

    [Fact(DisplayName = "01 · Uppgift 8: Storsta – största talet i mitten")]
    public void StorstaMitten() => Assert.Equal(9, Ovningar.Storsta(new[] { 4, 9, 2 }));

    [Fact(DisplayName = "01 · Uppgift 8: Storsta – största talet först eller sist")]
    public void StorstaKanter()
    {
        Assert.Equal(12, Ovningar.Storsta(new[] { 12, 3, 5 }));
        Assert.Equal(12, Ovningar.Storsta(new[] { 3, 5, 12 }));
    }

    [Fact(DisplayName = "01 · Uppgift 8: Storsta – bara negativa tal")]
    public void StorstaNegativa() => Assert.Equal(-2, Ovningar.Storsta(new[] { -5, -2, -8 }));

    [Fact(DisplayName = "01 · Uppgift 9: AntalStorreAn – vanligt fall")]
    public void AntalVanligt() => Assert.Equal(3, Ovningar.AntalStorreAn(new[] { 3, 8, 1, 9, 5 }, 4));

    [Fact(DisplayName = "01 · Uppgift 9: AntalStorreAn – lika med gränsen räknas inte")]
    public void AntalLikaMed() => Assert.Equal(1, Ovningar.AntalStorreAn(new[] { 4, 4, 5 }, 4));

    [Fact(DisplayName = "01 · Uppgift 9: AntalStorreAn – inga träffar")]
    public void AntalInga() => Assert.Equal(0, Ovningar.AntalStorreAn(new[] { 1, 2, 3 }, 10));

    [Fact(DisplayName = "01 · Uppgift 10: Medelvarde – jämnt resultat")]
    public void MedelJamnt() => Assert.Equal(4.0, Ovningar.Medelvarde(new[] { 2, 4, 6 }), 5);

    [Fact(DisplayName = "01 · Uppgift 10: Medelvarde – med decimaler")]
    public void MedelDecimaler() => Assert.Equal(1.5, Ovningar.Medelvarde(new[] { 1, 2 }), 5);

    [Fact(DisplayName = "01 · Uppgift 10: Medelvarde – tom array ger 0")]
    public void MedelTom() => Assert.Equal(0.0, Ovningar.Medelvarde(new int[0]), 5);

    [Fact(DisplayName = "01 · Uppgift 11: Vand – vänder arrayen")]
    public void Vand() => Assert.Equal(new[] { 3, 2, 1 }, Ovningar.Vand(new[] { 1, 2, 3 }));

    [Fact(DisplayName = "01 · Uppgift 11: Vand – tom array och ett tal")]
    public void VandKantfall()
    {
        Assert.Empty(Ovningar.Vand(new int[0]));
        Assert.Equal(new[] { 7 }, Ovningar.Vand(new[] { 7 }));
    }

    [Fact(DisplayName = "01 · Uppgift 11: Vand – originalet ändras inte")]
    public void VandOriginal()
    {
        var original = new[] { 1, 2, 3, 4 };
        Ovningar.Vand(original);
        Assert.Equal(new[] { 1, 2, 3, 4 }, original);
    }
}

public class Regler
{
    [Fact(DisplayName = "01 · Regel: Inga färdiga hjälpmetoder används i Grunder.cs")]
    public void IngaFardigaMetoder()
    {
        var kod = File.ReadAllText(HittaElevfilen());

        // Ta bort kommentarer så att det går att skriva om metoderna i en kommentar.
        kod = Regex.Replace(kod, @"/\*.*?\*/", "", RegexOptions.Singleline);
        kod = Regex.Replace(kod, @"//.*", "");

        string[] forbjudet = { "Math.Max", "Math.Min", ".Sum(", ".Max(", ".Min(", ".Average(", ".Count(", "Reverse(", ".Sort(", "OrderBy" };
        foreach (var ord in forbjudet)
        {
            Assert.False(kod.Contains(ord),
                $"Du använder '{ord}' i Grunder.cs. Lös uppgiften med if-satser och loopar i stället.");
        }
    }

    private static string HittaElevfilen()
    {
        var mapp = new DirectoryInfo(AppContext.BaseDirectory);
        while (mapp != null)
        {
            var fil = Path.Combine(mapp.FullName, "Grunder", "Grunder.cs");
            if (File.Exists(fil)) return fil;
            mapp = mapp.Parent;
        }
        throw new FileNotFoundException("Hittade inte Grunder/Grunder.cs");
    }
}
