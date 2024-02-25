namespace ZZZ.Domain.Helper;

public abstract class MemberBase
{
    public static MemberBase Create(int kind)
    {
        if (kind == 1)
        {
            return new SilverMember();
        }

        return new GoldMember();
    }
}
