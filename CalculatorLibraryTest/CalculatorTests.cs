namespace LogicCalculator;

[TestClass]
public class CalculatorTests
{
    /// <summary>
    /// Test method designed to make sure the ValueDict is being updated correctly
    /// </summary>
    [TestMethod]
    public void TestGetDict()
    {
        Calculator c = new();
        c.AddValue("a", "b");
        Assert.AreEqual("b", c.getValue("a"));
        c.AddValue("a", "c");
        Assert.AreEqual("c", c.getValue("a"));
    }
}