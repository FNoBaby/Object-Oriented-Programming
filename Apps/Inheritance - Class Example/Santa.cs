public class Santa : Individual
{
    private List<Gift> gifts;

    public List<Gift> Gifts
    {
        get
        {
            return gifts;
        }
        set
        {
            gifts = value;
        }
    }

    public Santa(string name, int age) : base(name, age)
    {
        this.gifts = new List<Gift>();
    }

    public Boolean AddGift(Gift gift)
    {
        if (gifts.Count >= 10)
        {
            return false;
        }
        else
        {
            gifts.Add(gift);
            return true;
        }
    }

    public string DeliverGifts()
    {
        string giftsDelivered = "";
        foreach (Gift gift in gifts)
        {
            giftsDelivered += gift.Describe() + "\n ";
        }
        gifts.Clear();
        return giftsDelivered;
    }
}