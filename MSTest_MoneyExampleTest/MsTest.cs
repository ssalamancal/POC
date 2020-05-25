using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoneyExample;

namespace MSTest_MoneyExampleTest
{
  [TestClass]
  public class MsTest
  {
    [TestMethod]
    public void TestMultiplication()
    {
      Dollar five = new Dollar(5);

      five.Times(2);
      
      Assert.AreEqual(10, five.amount);
    }
  }
}
