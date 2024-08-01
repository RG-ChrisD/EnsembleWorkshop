using Ensemble;

namespace EnsembleTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(3, "III")]
    [TestCase(4,"IV")]
    [TestCase(5, "V")]
    [TestCase(6, "VI")]
    [TestCase(7, "VII")]
    [TestCase(8, "VIII")]
    [TestCase(9,"IX")]
    [TestCase(10,"X")]
    [TestCase(19,"XIX")]
    [TestCase(20,"XX")]
    [TestCase(49,"XLIX")]
    [TestCase(50,"L")]
    [TestCase(99,"XCIX")]
    [TestCase(100, "C")]
    [TestCase(1000, "M")]
    public void Test1(int input, string expected)
    {
        Assert.AreEqual(expected, Class1.ToRomanNumerals(input));
    }
}