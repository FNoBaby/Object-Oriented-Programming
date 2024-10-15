while (true)
{

    Random random = new Random();
    int randomNumber = random.Next(1, 101);
    int guesses = 0;

    while (true)
    {
        Console.WriteLine("Enter a number between 1 and 100: ");
        int userNumber = int.Parse(Console.ReadLine());

        if (userNumber == randomNumber)
        {
            Console.WriteLine("Congratulations! You guessed the number!");
            Console.WriteLine("Number of guesses: " , guesses);
            break;
        }
        else if (userNumber < randomNumber)
        {
            Console.WriteLine("The number is greater than the one you entered.");
            guesses++;
        }
        else
        {
            Console.WriteLine("The number is less than the one you entered.");
            guesses++;
        }
    }

    Console.WriteLine("Do you want to play again? (yes/no)");
    string answer = Console.ReadLine();

    switch(answer)
    {
        case "yes":
            Console.Clear();
            continue;
        case "no":
            return;
        default:
            Console.WriteLine("Invalid input. Exiting the game.");
            return;
    }
}