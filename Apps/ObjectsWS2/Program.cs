namespace ObjectsWS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                We need to implement the following scenario
                3 people are running a Race. We know the name and the nmber of each athlete.
                Once they finish their run, they need to register with the Race official and their time taken is logged.
                The race official will eventually be able to determine who won the race.
            */
            Athlete athlete1 = new Athlete("John", 1);
            Athlete athlete2 = new Athlete("Jane", 2);
            Athlete athlete3 = new Athlete("Jim", 3);

            RaceOfficial official = new RaceOfficial();

            Random random = new Random();
            official.RegisterAthlete(athlete1, random.Next(0, 100));
            official.RegisterAthlete(athlete2, random.Next(0, 100));
            official.RegisterAthlete(athlete3, random.Next(0, 100));

            Console.WriteLine("The winner is: " + official.GetWinner().ToString());

        }
    }
}
