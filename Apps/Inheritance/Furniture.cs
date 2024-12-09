public class Furniture : Product {
    private string material;
    private int weight;

    public string Material {
        get { return this.material; }
        set { this.material = value; }
    }

    public int Weight {
        get { return this.weight; }
        set { this.weight = value; }
    }

    public Furniture(int id, string name, double price, int stockQuantity, string material, int weight) : base(id, name, price, stockQuantity) {
        this.Material = material;
        this.Weight = weight;
    }

    public Boolean EligibleForDelivery() {
        return this.Weight < 40000;
    }

    public string GetInfo(){
        return $"Id: {Id}, Name: {Name}, Price: {Price}, Material: {Material}, Weight: {Weight}";
    }
}