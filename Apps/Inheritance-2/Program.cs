using System;
using System.Collections.Generic;

namespace Inheritance_2
{
    /*
A christmas market stall sells home-made snacks. The menu is:
- Currywurst with mustard: 2.00
- Currywurst with mustard and onion : 2.50
- Simple Lebkuchen: 1.00
- Spiced Lebkuhen: 1.10
- Chocolate Lebkuchen: 1.25

All the snacks have a price, cannot be negative and a description.
Write a program that creates a few menu items and adds them to a list.
The program should calculate the total price and print out the bill.
*/

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Food> menu = new List<Food>();
            menu.Add(new Currywurst(CurrywurstTypes.Mustard, "Currywurst with mustard" , 2));
            menu.Add(new Currywurst(CurrywurstTypes.MustardAndOnion, "Currywurst with mustard and onion" , 5));
            menu.Add(new Lebkuchen(LebkuchenTypes.Plain, "Simple Lebkuchen" , 6));
            menu.Add(new Lebkuchen(LebkuchenTypes.Spiced, "Spiced Lebkuchen", 10));
            menu.Add(new Lebkuchen(LebkuchenTypes.Chocolate, "Chocolate Lebkuchen" , 20));

            double total = 0;
            foreach (var item in menu)
            {
                double finalPrice = item.GetFinalPrice();
                Console.WriteLine($"{item.Description}: {finalPrice:C}");
                total += finalPrice;
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Total: {total:C}");
        }
    }
}
