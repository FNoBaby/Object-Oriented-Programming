public class Clothing : Product
{
    private String size;
    private String material;


    public string Size
    {
        get { return this.size; }
        set { this.size = value; }
    }

    public string Material
    {
        get { return this.material; }
        set { this.material = value; }
    }

    public Clothing(int id, string name, double price, int stockQuantity, string size, string material) : base(id, name, price, stockQuantity)
    {
        this.Size = size;
        this.Material = material;
    }

    public string GetInfo()
    {
        return $"Id: {Id}, Name: {Name}, Price: {Price}, Size: {Size}, Material: {Material}";
    }

    public Boolean IsAvailable()
    {
        return StockQuantity > 0;
    }
}