
namespace ZZZ.Domain.Helper;

public class ProductId(int value)
{
    public int Value { get; } = value;

    public override bool Equals(object? obj)
    {
        return obj is ProductId id &&
            Value == id.Value;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Value);
    }
}
