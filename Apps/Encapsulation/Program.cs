using System;
namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Machine machine = new Machine();
                Glass glass = new Glass();

                Console.WriteLine("--------Menu--------");
                Console.WriteLine("1. Refill Tank 1");
                Console.WriteLine("2. Refill Tank 2");
                Console.WriteLine("3. Fill Glass from Tank 1");
                Console.WriteLine("4. Fill Glass from Tank 2");
                Console.WriteLine("5. Check Tank 1 Level");
                Console.WriteLine("6. Check Tank 2 Level");
                Console.WriteLine("7. Exit");
                Console.WriteLine("--------------------");
                Console.WriteLine("Enter your choice: ");
                
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Tank 1 refilled");
                        machine.refillTank1();
                        break;
                    case 2:
                        Console.WriteLine("Tank 2 refilled");
                        machine.refillTank2();
                        break;
                    case 3:
                        if (glass.refillGlassFromTank1(machine))
                        {
                            Console.WriteLine("Glass filled from Tank 1");
                        }
                        else
                        {
                            Console.WriteLine("Please refill Tank 1");
                        }
                        break;
                    case 4:
                        if (glass.refillGlassFromTank2(machine))
                        {
                            Console.WriteLine("Glass filled from Tank 2");
                        }
                        else
                        {
                            Console.WriteLine("Please refill Tank 2");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Tank 1: " + machine.getLevelTank1());
                        break;
                    case 6:
                        Console.WriteLine("Tank 2: " + machine.getLevelTank2());
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
