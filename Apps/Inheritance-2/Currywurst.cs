public class Currywurst : Food
{
    public CurrywurstTypes Toppings { get; set; }
    public Currywurst(CurrywurstTypes toppings, string description, int stock): base(description, stock)
    {
        this.Toppings = toppings;
        switch (toppings)
        {
            case CurrywurstTypes.Mustard:
                Price = 2.00;
                break;
            case CurrywurstTypes.MustardAndOnion:
                Price = 2.50;
                break;
        }
    }
}
