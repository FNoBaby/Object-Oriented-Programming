public class Orange : Fruit{

    public Orange(String countryOfOrigin, Boolean organic, DateTime datePicked) : base("Orange", countryOfOrigin, organic, datePicked){
    }

    public override String getInformation(){
        return "Orange from: " + CountryOfOrigin + " picked on: " + DatePicked.ToString("MM/dd/yyyy") + " organic: " + Organic ;
    }
}