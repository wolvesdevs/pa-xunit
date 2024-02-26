using System.Diagnostics;
using Xunit.Abstractions;

namespace ZZZ.Tests;

public class UnitTest3(ITestOutputHelper outputhelper)
{
    private readonly ITestOutputHelper _outputhelper = outputhelper;

    [Fact]
    public void ログの出力()
    {
        Debug.WriteLine("ログの出力");
        _outputhelper.WriteLine("ログの出力: IN");
        Assert.Equal(1, 1);
        _outputhelper.WriteLine("ログの出力: OUT");
    }
}
