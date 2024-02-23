namespace ZZZ.UI.ViewModels;

public class ProductViewModel
{
    public bool IsChecked { get; set; } = true;
    public bool IsReadOnly { get; set; }
    public int Price { get; set; }
    public object PriceText => $"{Price}円";
}
