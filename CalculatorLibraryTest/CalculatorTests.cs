namespace Calculator;

[TestClass]
public class CalculatorTests
{
    /// <summary>
    /// Test method designed to make sure the ValueDict is being updated correctly
    /// </summary>
    [TestMethod]
    public void TestGetDict()
    {
        Calculator c = new Calculator();
        c.AddValue("a", "b");
        Assert.AreEqual("b", c.getValue("a"));
    }
}