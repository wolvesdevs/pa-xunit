
namespace ZZZ.UI.ViewModels;

public class ProductViewModel
{
    public bool IsChecked { get; set; } = true;
    public bool IsReadOnly { get; set; }
    public int Price { get; set; }
    public object PriceText => $"{Price}円";

    public double Divide(double v1, double v2)
    {
        return v1 / v2;
    }
}
