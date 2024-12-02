public class Furniture : Product {
    public string Material { get; set; }
    public int Weight { get; set; }

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