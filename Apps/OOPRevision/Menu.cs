public class Menu : Item{
    private Soup soup;
    private Fruit fruit;
    private double price;
    public Soup Soup{
        get{
            return soup;
        }
    }

    public Fruit Fruit{
        get{
            return fruit;
        }
    }

    public double Price{
        get{
            return price;
        }
    }

    public Menu(Soup soup, Fruit fruit, double price){
        this.soup = soup;
        this.fruit = fruit;
        this.price = price;
    }

    public override String getInformation(){
        return "Menu: " + soup.getInformation() + " and " + fruit.getInformation() + " for " + price;
    }
}