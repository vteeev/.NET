using Consol_APP;
using NUnit.Framework;

[TestFixture]
public class TextAnalyzerTests
{
    [Test]
    public void LiczbaZnakowZeSpacjami_ShouldReturnCorrectNumber()
    {
        var text = "Hello, world!";
        int result = TextAnalyzer.LiczbaZnakowZeSpacjami(text);
        Assert.AreEqual(13, result);
    }

    [Test]
    public void LiczbaZnakowBezSpacji_ShouldReturnCorrectNumber()
    {
        var text = "Hello, world!";
        int result = TextAnalyzer.LiczbaZnakowBezSpacji(text);
        Assert.AreEqual(12, result);
    }

    [Test]
    public void LiczbaCyfr_ShouldReturnCorrectNumber()
    {
        var text = "Hello 123 world 456!";
        int result = TextAnalyzer.LiczbaCyfr(text);
        Assert.AreEqual(6, result); 
    }

    [Test]
    public void LiczbaLiter_ShouldReturnCorrectNumber()
    {
        var text = "Hello 123 world!";
        int result = TextAnalyzer.LiczbaLiter(text);
        Assert.AreEqual(10, result);  
    }

    [Test]
    public void LiczbaSlow_ShouldReturnCorrectNumber()
    {
        var text = "Hello world!";
        int result = TextAnalyzer.LiczbaSlow(text);
        Assert.AreEqual(2, result); 
    }

    [Test]
    public void LiczbaUnikalnychSlow_ShouldReturnCorrectNumber()
    {
        var text = "apple banana apple orange banana";
        int result = TextAnalyzer.LiczbaUnikalnychSlow(text);
        Assert.AreEqual(3, result); 
    }

    [Test]
    public void NajczesciejWystepujaceSlowo_ShouldReturnCorrectWord()
    {
        var text = "apple banana apple orange apple banana";
        string result = TextAnalyzer.NajczesciejWystepujaceSlowo(text);
        Assert.AreEqual("apple (3 razy)", result); 
    }

    [Test]
    public void SredniaDlugoscSlow_ShouldReturnCorrectAverage()
    {
        var text = "apple banana orange";
        double result = TextAnalyzer.SredniaDlugoscSlow(text);
        Assert.AreEqual(5.66, result, 0.01);  
    }

    [Test]
    public void NajkrotszeNajdluzszeSlowo_ShouldReturnCorrectWords()
    {
        var text = "apple banana orange";
        var (najkrotsze, najdluzsze) = TextAnalyzer.NajkrotszeNajdluzszeSlowo(text);
        Assert.AreEqual("apple", najkrotsze);
        Assert.AreEqual("banana", najdluzsze);
    }

    [Test]
    public void LiczbaZdan_ShouldReturnCorrectNumber()
    {
        var text = "Hello world! How are you? I am fine.";
        int result = TextAnalyzer.LiczbaZdan(text);
        Assert.AreEqual(3, result);
    }

    [Test]
    public void SredniaLiczbaSlowNaZdanie_ShouldReturnCorrectAverage()
    {
        var text = "Hello world! How are you? I am fine.";
        double result = TextAnalyzer.SredniaLiczbaSlowNaZdanie(text);
        Assert.AreEqual(2.66, result, 0.01);
    }

    [Test]
    public void NajdluzszeZdanie_ShouldReturnCorrectNumber()
    {
        var text = "Hello world! How old are you? I am fine.";
        int result = TextAnalyzer.NajdluzszeZdanie(text);
        Assert.AreEqual(4, result);
    }

    [Test]
    public void LiczbaZnakowInterpunkcyjnych_ShouldReturnCorrectNumber()
    {
        var text = "Hello, world! How are you?";
        int result = TextAnalyzer.LiczbaZnakowInterpunkcyjnych(text);
        Assert.AreEqual(3, result);
    }

    [Test]
    public void AnalyzeText_WithEmptyString_ShouldReturnZeroes()
    {
        var text = "";
        var result = TextAnalyzer.LiczbaZnakowZeSpacjami(text);
        Assert.AreEqual(0, result);

        result = TextAnalyzer.LiczbaZnakowBezSpacji(text);
        Assert.AreEqual(0, result);

        result = TextAnalyzer.LiczbaCyfr(text);
        Assert.AreEqual(0, result);

        result = TextAnalyzer.LiczbaLiter(text);
        Assert.AreEqual(0, result);

        result = TextAnalyzer.LiczbaSlow(text);
        Assert.AreEqual(0, result);

        result = TextAnalyzer.LiczbaUnikalnychSlow(text);
        Assert.AreEqual(0, result); 

        var mostCommonWord = TextAnalyzer.NajczesciejWystepujaceSlowo(text);
        Assert.AreEqual("Brak słów w tekście", mostCommonWord);

        double averageWordLength = TextAnalyzer.SredniaDlugoscSlow(text);
        Assert.AreEqual(0, averageWordLength);

        var (najkrotsze, najdluzsze) = TextAnalyzer.NajkrotszeNajdluzszeSlowo(text);
        Assert.AreEqual("Brak słów", najkrotsze); 
        Assert.AreEqual("Brak słów", najdluzsze); 

        result = TextAnalyzer.LiczbaZdan(text);
        Assert.AreEqual(0, result);

        double averageWordsPerSentence = TextAnalyzer.SredniaLiczbaSlowNaZdanie(text);
        Assert.AreEqual(0, averageWordsPerSentence);

        result = TextAnalyzer.NajdluzszeZdanie(text);
        Assert.AreEqual(0, result);

        result = TextAnalyzer.LiczbaZnakowInterpunkcyjnych(text);
        Assert.AreEqual(0, result);
    }
}
