using MoneyExample;
using NUnit.Framework;

namespace nUnit_MoneyExampleTest
{
  public class nUnit
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestMultiplication()
    {
      Dollar five = new Dollar(5);

      five.Times(2);

      Assert.AreEqual(10, five.amount);
    }
  }
}