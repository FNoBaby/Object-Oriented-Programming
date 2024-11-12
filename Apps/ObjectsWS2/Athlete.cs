namespace ObjectsWS2
{
    public class Athlete
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public int Time { get; private set; }

        public Athlete(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public void RegisterTime(int time)
        {
            Time = time;
        }

        public override string ToString()
        {
            return $"Athlete: {Name}, Number: {Number}, Time: {Time}";
        }
    }
}