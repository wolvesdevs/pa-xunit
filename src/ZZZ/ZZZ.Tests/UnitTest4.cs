using ZZZ.UI.ViewModels;

namespace ZZZ.Tests;

public class UnitTest4
{
    private int _intValue = 4;
    private ProductViewModel _vm = new();

    [Fact]
    public void Test4A()
    {
        _intValue++;
        Assert.Equal(5, _intValue);
        Assert.True(_vm.IsChecked);
    }

    [Fact]
    public void Test4B()
    {
        _intValue++;
        Assert.Equal(5, _intValue);
        Assert.Equal(2, _vm.Divide(10, 5));
    }

}
