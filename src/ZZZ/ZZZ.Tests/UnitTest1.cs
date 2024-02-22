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
}