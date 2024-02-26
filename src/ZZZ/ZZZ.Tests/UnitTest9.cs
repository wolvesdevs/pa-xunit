using ZZZ.UI.ViewModels;

namespace ZZZ.Tests;

public class UnitTest9
{
    [Theory]
    [MemberData(nameof(TestHelper.CsvRead), MemberType = typeof(TestHelper))]
    public void TestXD(int price, string result)
    {
        ProductViewModel vm = new();

        vm.Price = price;
        Assert.Equal(result, vm.GetTaxPrice());
    }
}
