int seconds;

do
{
    Console.WriteLine("Enter the number of seconds for the countdown: ");
    seconds = int.Parse(Console.ReadLine());
} while (seconds < 5);

for (int i = seconds; i > 0; i--)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine("Timer: " + i);
    Thread.Sleep(1000);
}