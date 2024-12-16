public class Gift{
    private string name;
    private string recipient;
    private Boolean isWrapped;

    public string Name{
        get{
            return name;
        }
        set{
            name = value;
        }
    }

    public string Recipient{
        get{
            return recipient;
        }
        set{
            recipient = value;
        }
    }

    public Boolean IsWrapped{
        get{
            return isWrapped;
        }
    }

    public Gift(string name, string recipient){
        Name = name;
        Recipient = recipient;
        isWrapped = false;
    }

    public void Wrap(){
        isWrapped = true;
    }

    public string Describe(){
        return $"Gift : \n Name: {name} \n Recipient: {recipient} \n Wrapped: {isWrapped}";
    }
}