using ZZZ.Domain.Helper;

namespace ZZZ.Tests;

[Collection("ABCollection")]
public class UnitTestB(ABShared shared)
{
    private ABShared _shared = shared;

    [Fact]
    public void TestB1()
    {
        _shared.IntValue++;
        _shared.StringValue = "BBB";
    }
}
