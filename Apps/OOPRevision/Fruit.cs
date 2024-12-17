public class Fruit : Item{
    private String countryOfOrigin;
    private Boolean organic;
    private DateTime datePicked;

    public String CountryOfOrigin{
        get{
            return countryOfOrigin;
        }
    }

    public Boolean Organic{
        get{
            return organic;
        }
    }

    public DateTime DatePicked{
        get{
            return datePicked;
        }
    }

    public Fruit(String name, String countryOfOrigin, Boolean organic, DateTime datePicked) : base(){
        this.countryOfOrigin = countryOfOrigin;
        this.organic = organic;
        this.datePicked = datePicked;
    }

    public override String getInformation(){
        return "Fruit from: " + countryOfOrigin + " picked on: " + datePicked.ToString("MM/dd/yyyy") + " organic: " + organic ;
    }
}