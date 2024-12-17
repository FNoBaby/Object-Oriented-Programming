namespace OOPRevision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menuItem = new Menu(
                new Soup("Mushroom Soup", new List<String> { "Mushroom", "Onion", "Garlic" }),
                new Grape(true, "Italy", true, new DateTime(2021, 10, 10)),
                5.00
            );

            Console.WriteLine(menuItem.getInformation());
        }
    }
}
