public class Food : Product{
    private DateTime expiryDate;
    private string ingredients;

    public DateTime ExpiryDate{
        get { return this.expiryDate; }
        set { this.expiryDate = value; }
    }

    public string Ingredients{
        get { return this.ingredients; }
        set { this.ingredients = value; }
    }

    public Food(int id, string name, double price, int stockQuantity, DateTime expiryDate, string ingredients) : base(id, name, price, stockQuantity) {
        this.ExpiryDate = expiryDate;
        this.Ingredients = ingredients;
    }

    public Boolean CheckExpiration(){
        return DateTime.Now < ExpiryDate;
    }

    public string GetInfo(){
        return $"Id: {Id}, Name: {Name}, Price: {Price}, Expiry Date: {ExpiryDate}, Ingredients: {Ingredients}";
    }
}