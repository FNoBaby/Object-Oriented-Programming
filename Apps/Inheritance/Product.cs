public class Product{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int StockQuantity { get; set; }

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