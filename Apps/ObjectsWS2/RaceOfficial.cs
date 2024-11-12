using System;

namespace ObjectsWS2
{
    public class RaceOfficial
    {

        private List<Athlete> RegisteredAthletes { get; set; } = new List<Athlete>();

        public RaceOfficial(){}

        public void RegisterAthlete(Athlete athlete, int minutes)
        {
            athlete.RegisterTime(minutes);
            RegisteredAthletes.Add(athlete);

            Console.WriteLine("Athlete " + athlete.Name + " registered with time " + minutes);
        }

        public Athlete GetWinner()
        {
            Athlete winner = RegisteredAthletes[0];
            foreach (Athlete athlete in RegisteredAthletes)
            {
                if (athlete.Time < winner.Time)
                {
                    winner = athlete;
                }
            }

            return winner;
        }
    }
}