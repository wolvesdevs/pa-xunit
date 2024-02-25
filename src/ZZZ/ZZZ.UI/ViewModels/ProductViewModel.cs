using System.ComponentModel;
using ZZZ.Domain.Exceptions;
using ZZZ.Domain.Helper;

namespace ZZZ.UI.ViewModels;

public class ProductViewModel : INotifyPropertyChanged
{
    public bool IsChecked { get; set; } = true;
    public bool IsReadOnly { get; set; }
    public int Price { get; set; }
    public object PriceText => $"{Price}円";
    public Product Product { get; set; }
    public event EventHandler<int> PriceChanged;
    public event PropertyChangedEventHandler? PropertyChanged;

    private string _productName;
    public string ProductName
    {
        get => _productName;
        set
        {
            _productName = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ProductName)));
        }
    }

    public void ChangePrice(int price)
    {
        Price = price;
        PriceChanged?.Invoke(this, Price);
    }

    public void CreateProduct()
    {
        Product = new Product();
    }

    public double Divide(double v1, double v2)
    {
        return v1 / v2;
    }

    public void Save(string value)
    {
        if (value is null)
        {
            throw new SaveException("valueがNULLです");
        }
    }
}
