public class Individual{
    private string name;
    private int age;

    public string Name{
        get{
            return name;
        }
        set{
            name = value;
        }
    }

    public int Age{
        get{
            return age;
        }
        set{
            age = value;
        }
    }

    public Individual(string name, int age){
        this.name = name;
        Age = age;
    }

    public string Introduce(){
        return $"My name is {name} and I am {age} years old.";
    }
}