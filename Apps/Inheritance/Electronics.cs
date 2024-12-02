public class Electronics : Product {
    public int WarrentyPeriod { get; set; }
    public int PowerConsumption { get; set; }

    public Electronics(int id, string name, double price, int stockQuantity, int warrentyPeriod, int powerConsumption) : base(id, name, price, stockQuantity) {
        this.WarrentyPeriod = warrentyPeriod;
        this.PowerConsumption = powerConsumption;
    }

    public Boolean IsEnergyEfficient() {
        return this.PowerConsumption < 100;
    }

    public string GetInfo(){
        return $"Id: {Id}, Name: {Name}, Price: {Price}, Warrenty Period: {WarrentyPeriod}, Power Consumption: {PowerConsumption}";
    }
}