using ZZZ.Domain.Helper;

namespace ZZZ.Tests;

public class UnitTest5 : IDisposable
{
    public void Dispose()
    {
        Shared.IsDatabase = false;
    }

    [Fact]
    public void Test5A()
    {
        Assert.False(Shared.IsDatabase);
        Shared.IsDatabase = true;
        Assert.True(Shared.IsDatabase);
    }

    [Fact]
    public void Test5B()
    {
        Assert.False(Shared.IsDatabase);
        Shared.IsDatabase = true;
        Assert.True(Shared.IsDatabase);
    }

}
