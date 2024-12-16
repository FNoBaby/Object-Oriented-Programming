public class Elf : Individual{
    private ElfRoleEnum role;

    public ElfRoleEnum Role{
        get{
            return role;
        }
        set{
            role = value;
        }
    }

    public Elf(string name, int age, ElfRoleEnum role) : base(name, age){
        Role = role;
    }

    public string Work(){
        return $"I am an elf and I am a {role}.";
    }
}