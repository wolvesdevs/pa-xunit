using ZZZ.UI.ViewModels;

namespace ZZZ.Tests;

public class UnitTest8
{
    [Fact]
    public void TestA()
    {
        ProductViewModel vm = new();

        vm.Price = 0;
        Assert.Equal("0円", vm.GetTaxPrice());

        vm.Price = 100;
        Assert.Equal("108円", vm.GetTaxPrice());
    }

    [Fact]
    public void TestB()
    {
        ProductViewModel vm = new();

        vm.Price = 333;
        Assert.Equal("359円", vm.GetTaxPrice());
    }

    [Theory]
    [InlineData(0, "0円")]
    [InlineData(100, "108円")]
    [InlineData(101, "109円")]
    [InlineData(0, "無料", Skip = "昔のテスト")]
    public void TestX(int price, string result)
    {
        ProductViewModel vm = new();

        vm.Price = price;
        Assert.Equal(result, vm.GetTaxPrice());
    }
}
