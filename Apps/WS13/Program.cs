using System;

namespace WS13
{
    internal class Program
    {
        static int playerHealth = 100;
        static int playerDamage = 20;
        static int playerPoints = 0;
        static List<string> enemyNames = new List<string> { "Demobats", "Demodogs", "Demogorgan", "Spider Monster", "Mind Flayer", "Vecna" };
        static List<int> enemyHealth = new List<int> { 100, 100, 100, 100, 100, 100 };
        static List<int> enemyDamage = new List<int> { 5, 10, 15, 20, 25, 30 };
        static int enemyIndex = 0;
        static Random random = new Random();
        static Boolean won = false;

        static void ShowStatistics()
        {
            Console.WriteLine("Dungeons & Dragons");
            Console.WriteLine("------------------");
            Console.WriteLine("");
            Console.WriteLine("Player Health: " + playerHealth);
            Console.WriteLine("Player Points: " + playerPoints);
            Console.WriteLine("");
            Console.WriteLine("Enemy\t\tHealth\t\tPoints");
            Console.WriteLine("-----\t\t------\t\t------");
            for (int i = 0; i < enemyNames.Count; i++)
            {
                Console.WriteLine(enemyNames[i] + "\t\t" + enemyHealth[i] + "\t\t" + enemyDamage[i]);
            }

            Console.WriteLine("Press the enter key so that a random enemy will be generated...");
        }

        static void ShowStatistics(int enemyIndex)
        {
            Console.WriteLine("Dungeons & Dragons");
            Console.WriteLine("------------------");
            Console.WriteLine("");
            Console.WriteLine("Player Health: " + playerHealth);
            Console.WriteLine("Player Points: " + playerPoints);
            Console.WriteLine("");
            Console.WriteLine("Enemy\t\tHealth\t\tPoints");
            Console.WriteLine("-----\t\t------\t\t------");
            Console.WriteLine(enemyNames[enemyIndex] + "\t\t" + enemyHealth[enemyIndex] + "\t\t" + enemyDamage[enemyIndex]);
        }

        static void Attack()
        {
            Console.WriteLine("Will you win or lose this battle? Press the enter key to find out...");
            int attackSuccess = random.Next(0, 2);

            switch(attackSuccess){
                case 0:
                    Console.WriteLine("You have lost the battle");
                    playerHealth -= enemyDamage[enemyIndex];
                    break;
                case 1:
                    Console.WriteLine("You have won the battle");
                    playerPoints += enemyDamage[enemyIndex];
                    enemyHealth[enemyIndex] -= playerDamage;
                    if (enemyHealth[enemyIndex] <= 0)
                    {
                        Console.WriteLine("You have defeated the enemy");
                        enemyNames.RemoveAt(enemyIndex);
                        enemyHealth.RemoveAt(enemyIndex);
                        enemyDamage.RemoveAt(enemyIndex);
                        won = true;
                    }
                    break;
            }
        }

        static void Heal()
        {
            if (playerPoints >= 10)
            {
                playerHealth += 10;
                playerPoints -= 10;
                Console.WriteLine("Healing Complete");
            }
            else
            {
                Console.WriteLine("You do not have enough points to heal");
            }
        }
        static void Main(string[] args)
        {
            Boolean quit = false;
            ShowStatistics();
            Console.ReadLine();
            enemyIndex = random.Next(0, enemyNames.Count);


            while (playerHealth > 0 || !won || !quit)
            {
                ShowStatistics(enemyIndex);

                Console.WriteLine("Choose your move");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Hide");
                Console.WriteLine("3. Heal (Using 10 points)");
                Console.WriteLine("4. Quit");
                Console.WriteLine("Menu Option:");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Attack();
                        break;
                    case 2:
                        Console.WriteLine("Your character has hidden in a shed!");
                        break;
                    case 3:
                        Heal();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for joining the game. Hope to see you soon");
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

            }
        }
    }
}
