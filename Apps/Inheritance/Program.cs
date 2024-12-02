using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            List<Product> products = new List<Product>();

            products.Add(new Electronics(1, "Laptop", 50000, 10, 2, 100));
            products.Add(new Clothing(2, "T-Shirt", 500, 20, "M", "Cotton"));
            products.Add(new Furniture(3, "Table", 1000, 5, "Wood", 20000));
            products.Add(new Food(4, "Bread", 50, 100, new DateTime(2021, 12, 31) , "Flour, Yeast, Water"));

            foreach (Product product in products)
            {   
                Console.WriteLine($"Discounted Price:{Math.Round(product.ApplyDiscount(20), 2)}");
                if(product is Electronics e){
                    Console.WriteLine(e.GetInfo());
                    Console.WriteLine(e.GetInfo());
                    Console.WriteLine(e.IsEnergyEfficient());
                }
                else if(product is Clothing c){
                    Console.WriteLine(c.GetInfo());
                    Console.WriteLine(c.GetInfo());
                    Console.WriteLine(c.IsAvailable());
                }
                else if(product is Furniture f){
                    Console.WriteLine(f.GetInfo());
                    Console.WriteLine(f.GetInfo());
                    Console.WriteLine(f.EligibleForDelivery());
                }
                else if(product is Food food){
                    Console.WriteLine(food.GetInfo());
                    Console.WriteLine($"Is Expired: {food.CheckExpiration()}");
                }
            }
        }
    }
}
