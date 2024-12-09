public class Food{
    public double Price { get; protected set; }
    public string Description { get; set; }

    public int Stock { get; set; }

    public Food(string description, int stock)
    {
        Description = description;
        Stock = stock;
    }

    public double GetFinalPrice()
    {
        return Price;
    }
}