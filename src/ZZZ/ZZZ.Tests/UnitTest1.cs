using System.Collections;
using ZZZ.UI.ViewModels;

namespace ZZZ.Tests;

public class UnitTest1
{
    [Fact]
    public void �ŏ��̃e�X�g_����()
    {
        int value = 123;
        Assert.Equal(123, value);

        string stringValue = "abc";
        stringValue.Is("abc");
    }

    [Fact]
    public void bool�̃e�X�g()
    {
        var vm = new ProductViewModel();
        vm.IsChecked.IsTrue();
        vm.IsReadOnly.IsFalse();
    }

    [Fact]
    public void �����̃e�X�g()
    {
        ProductViewModel vm = new();
        vm.Price = 123;
        vm.PriceText.Is("123�~");
    }
}