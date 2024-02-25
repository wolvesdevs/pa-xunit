using System.Collections;
using ZZZ.UI.ViewModels;

namespace ZZZ.Tests;

public class UnitTest1
{
    [Fact]
    public void 最初のテスト_成功()
    {
        int value = 123;
        Assert.Equal(123, value);

        string stringValue = "abc";
        //stringValue.Is("abc");
    }

    [Fact]
    public void boolのテスト()
    {
        var vm = new ProductViewModel();
        //vm.IsChecked.IsTrue();
        //vm.IsReadOnly.IsFalse();
    }

    [Fact]
    public void 文字のテスト()
    {
        ProductViewModel vm = new();
        vm.Price = 123;
        //vm.PriceText.Is("123円");

        Assert.StartsWith("Ab", "Abc123");
        Assert.EndsWith("23", "Abc123");
        Assert.Equal("Abc123", "AbC123", ignoreCase: true);
        Assert.Contains("c1", "Abc123");
    }

    [Fact]
    public void 正規表現のテスト()
    {
        Assert.DoesNotMatch("^[0-9]+$", "123A45");
        Assert.Matches("^[0-9]+$", "12345");

        Assert.DoesNotMatch("^[A-Za-z]+$", "ABC1");
        Assert.Matches("^[A-Za-z]+$", "Abc");
    }

    [Fact]
    public void 数値のテスト()
    {
        ProductViewModel vm = new();
        vm.Price = 123;
        Assert.Equal(123, vm.Price);
        Assert.NotEqual(555, vm.Price);

        Assert.InRange(vm.Price, 123, 200);
        Assert.NotInRange(vm.Price, 124, 200);
    }

    [Fact]
    public void 浮動小数点数のテスト()
    {
        ProductViewModel vm = new();
        var result = vm.Divide(100, 3);
        Assert.Equal(33.333333333333336, result);
        Assert.Equal(33.3333, result, 4);

        double d1 = 1.23442;
        Assert.Equal(1.2344, d1, 4);
    }

    [Fact]
    public void Nullのテスト()
    {
        ProductViewModel vm = new();
        Assert.Null(vm.Product);
        vm.CreateProduct();
        Assert.NotNull(vm.Product);
    }

    [Fact]
    public void コレクションのテスト_All()
    {
        List<string> items = ["AAA", "BBB", "CCC"];
        Assert.All(items, item => Assert.True(item.Length == 3));
    }

    [Fact]
    public void コレクションのテスト_Single()
    {
        List<int> items1 = [3];
        Assert.Single(items1);

        List<int> items2 = [1, 1, 2, 3, 3];
        Assert.Single(items2, item => item == 2);
        Assert.Single(items2, 2);

    }

}