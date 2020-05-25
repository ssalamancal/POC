using MoneyExample;
using Xunit;

namespace xUnit_MoneyExampleTest
{
  public class xUnit
  {
    [Fact]
    public void TestMultiplication()
    {
      Dollar five = new Dollar(5);

      five.Times(2);

      Assert.Equal(10, five.amount);
    }
  }
}
