public class Apple : Fruit{
    private String brand;

    private String Brand{
        get{
            return brand;
        }
    }

    public Apple(String brand, String countryOfOrigin, Boolean organic, DateTime datePicked) : base("Apple", countryOfOrigin, organic, datePicked){
        this.brand = brand;
    }

    public override String getInformation(){
        return "Apple from: " + CountryOfOrigin + " picked on: " + DatePicked.ToString("MM/dd/yyyy") + " organic: " + Organic + " brand: " + Brand;
    }
}