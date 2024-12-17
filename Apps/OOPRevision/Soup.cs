public class Soup : Item{
    private String name;

    private List<String> vegetables;

    public String Name{
        get{
            return name;
        }
    }

    public List<String> Vegetables{
        get{
            return vegetables;
        }
    }

    public Soup(String name, List<String> vegetables) : base(){
        this.name = name;
        this.vegetables = vegetables;
    }

    public override String getInformation(){
        return "Soup: " + name + " with vegetables: " + String.Join(", ", vegetables);
    }
}