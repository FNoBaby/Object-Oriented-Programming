public class Lebkuchen : Food
{
    public LebkuchenTypes Type { get; set; }
    public Lebkuchen(LebkuchenTypes type, string description, int stock): base(description, stock)
    {
        this.Type = type;
        switch (type)
        {
            case LebkuchenTypes.Plain:
                Price = 1.00;
                break;
            case LebkuchenTypes.Spiced:
                Price = 1.10;
                break;
            case LebkuchenTypes.Chocolate:
                Price = 1.25;
                break;
        }
    }
}
