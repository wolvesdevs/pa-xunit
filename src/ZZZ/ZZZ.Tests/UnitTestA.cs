using ZZZ.Domain.Helper;

namespace ZZZ.Tests;

[Collection("ABCollection")]
public class UnitTestA(ABShared shared)
{
    private ABShared _shared = shared;

    [Fact]
    public void TestA1()
    {
        _shared.IntValue++;
        _shared.StringValue = "AAA";
    }
}
