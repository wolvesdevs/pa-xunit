namespace ZZZ.Tests;

public class TaxDataSet
{
    public static IEnumerable<object[]> CaseA => new List<object[]>
    {
        new object[] {0, "0円"},
        new object[] {100, "108円"},
        new object[] {101, "109円"},
    };
}
