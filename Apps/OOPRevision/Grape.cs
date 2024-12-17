public class Grape : Fruit{
    private Boolean seedless;

    public Boolean Seedless{
        get{
            return seedless;
        }
    }

    public Grape(Boolean seedless, String countryOfOrigin, Boolean organic, DateTime datePicked) : base("Grape", countryOfOrigin, organic, datePicked){
        this.seedless = seedless;
    }

    public override String getInformation(){
        return "Grape from: " + CountryOfOrigin + " picked on: " + DatePicked.ToString("MM/dd/yyyy") + " organic: " + Organic + " seedless: " + Seedless;
    }
}