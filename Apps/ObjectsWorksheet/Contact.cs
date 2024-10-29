using System;

public class Contact
{
	public String nickname { get; set; }

	public int number { get; set; }
    public Contact(String nickname , int number)
	{
        this.nickname = nickname;
        this.number = number;
    }

    //Override the ToString method
    // override is used to define a method in the derived class that is already defined in the base class
    // in this case, the ToString method is defined in the Object class
    public override String ToString()
    {
        return "Contact{" +
                "nickname='" + nickname + '\'' +
                ", number=" + number +
                '}';
    }
}
