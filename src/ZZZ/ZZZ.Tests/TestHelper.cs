using System.ComponentModel;

namespace ZZZ.Tests;

public class TestHelper
{
    public static IEnumerable<object[]> CsvRead()
    {
        string filePath = "XXX.csv";
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("XXXX" + filePath);
        }

        var lines = File.ReadAllLines(filePath);
        var result = new List<object[]>();
        foreach (var line in lines)
        {
            var items = line.Split(',');
            result.Add(items);
        }

        return result;
    }
}
