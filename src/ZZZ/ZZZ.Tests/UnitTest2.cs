namespace ZZZ.Tests;

public class UnitTest2
{
    [Fact]
    [Trait("Category", "受注")]
    public void TestA()
    {
    }

    [Fact]
    [Trait("Category", "受注")]
    public void TestB()
    {
    }

    [Fact]
    [Trait("Category", "在庫")]
    public void TestC()
    {
    }

    [Fact]
    [Trait("Category", "受注")]
    [Trait("Category", "在庫")]
    public void TestD()
    {
    }

    [Fact]
    [Trait("Category", "受注")]
    [Trait("Priority", "High")]
    public void TestE()
    {
    }

    [Fact]
    [Trait("Owner", "XX開発Gr")]
    public void TestZ受注()
    {
    }

    [Fact(Skip = "バージョンアップに伴いこのテストは不要")]
    public void TestXXX()
    {
        Assert.Equal(1, 2);
    }

}
