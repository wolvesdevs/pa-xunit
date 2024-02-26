using ZZZ.Domain.Helper;

namespace ZZZ.Tests;

public class UnitTest6(UnitTest6Shared shared) : IClassFixture<UnitTest6Shared>
{
    private int _intValue = 0;
    private UnitTest6Shared _shared = shared;

    [Fact]
    public void Test6A()
    {
        _shared.IntValue++;
        Assert.Equal(1, _shared.IntValue);

        _shared.StringValue = "AAA";
        Assert.Equal("AAA", _shared.StringValue);
    }

    [Fact]
    public void Test6B()
    {
        _shared.IntValue++;
        Assert.Equal(2, _shared.IntValue);

        _shared.StringValue = "BBB";
        Assert.Equal("BBB", _shared.StringValue);
    }

}
