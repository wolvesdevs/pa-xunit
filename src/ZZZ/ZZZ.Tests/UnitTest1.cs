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
        stringValue.Is("abc");
    }

    [Fact]
    public void boolのテスト()
    {
        var vm = new ProductViewModel();
        vm.IsChecked.IsTrue();
        vm.IsReadOnly.IsFalse();
    }

    [Fact]
    public void 文字のテスト()
    {
        ProductViewModel vm = new();
        vm.Price = 123;
        vm.PriceText.Is("123円");

        Assert.StartsWith("Ab", "Abc123");
        Assert.EndsWith("23", "Abc123");
        Assert.Equal("Abc123", "AbC123", ignoreCase: true);
        Assert.Contains("c1", "Abc123");
    }
}