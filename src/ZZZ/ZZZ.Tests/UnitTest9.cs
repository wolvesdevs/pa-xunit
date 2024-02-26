using ZZZ.UI.ViewModels;

namespace ZZZ.Tests;

public class UnitTest9
{
    public static IEnumerable<object[]> XXXCsv => TestHelper.CsvRead("XXX.csv");

    [Theory]
    [MemberData(nameof(TestHelper.CsvRead), MemberType = typeof(TestHelper))]
    public void TestXD(int price, string result)
    {
        ProductViewModel vm = new();

        vm.Price = price;
        Assert.Equal(result, vm.GetTaxPrice());
    }

    [Theory]
    [MemberData(nameof(XXXCsv))]
    public void TestXE(int price, string result)
    {
        ProductViewModel vm = new();

        vm.Price = price;
        Assert.Equal(result, vm.GetTaxPrice());
    }
}
