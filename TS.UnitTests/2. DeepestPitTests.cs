using TS.TechnicalTest;

namespace TS.UnitTests;

[TestClass]
public class DeepestPitTests
{
    [TestMethod]
    public void Q2_BasicNominalTest()
    {
        var points = new[] {0, 1, 3, -2, 0, 1, -3, 2, 3};
        var result = DeepestPitAnswer.Solution(points);

        Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void Q2_RepeatingAscendingDescending()
    {
        var points = new[] { 1, 2, 3, 1, 2, 3, 1, 2, 3 };

        var result = DeepestPitAnswer.Solution(points);

        Assert.AreEqual(2, result);

    }

    [TestMethod]
    public void Q2_NoPitFound()
    {
        var points = new[] { 1, 2, 3, 4, 5};

        var result = DeepestPitAnswer.Solution(points);

        Assert.AreEqual(-1, result);

    }
}
