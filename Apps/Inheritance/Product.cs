public class Product{
    private int id; 
    private string name;
    private double price;
    private int stockQuantity;

    public int Id{
        get{ return id; }
        set{ id = value; }
    }

    public string Name{
        get{ return name; }
        set{ name = value; }
    }

    public double Price{
        get{ return price; }
        set{ price = value; }
    }

    public int StockQuantity{
        get{ return stockQuantity; }
        set{ stockQuantity = value; }
    }
    
    public Product(int id, string name, double price, int stockQuantity)
    {
        this.Id = id;
        this.Name = name;
        this.Price = price;
        this.StockQuantity = stockQuantity;
    }

    public string GetInfo(){
        return $"Id: {Id}, Name: {Name}, Price: {Price}, Stock Quantity: {StockQuantity}";
    }

    public double ApplyDiscount(int discountPercentage){
        return Price - (Price * discountPercentage / 100);
    }

}