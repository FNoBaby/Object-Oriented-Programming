class Main
{
    static void main(String[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        bool exit = false;

        vehicles.Add(new Vehicle("MCT-001", "Toyota", "Avensis", 1500, 7.9, 50));
        vehicles.Add(new Vehicle("MCT-002", "Honda", "Accord", 2000, 9.2, 60));
        vehicles.Add(new Vehicle("MCT-003", "Volkswagen", "Passat", 1800, 8.5, 70));

        while (!exit)
        {
            Console.Clear();

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.getData());
            }

            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Menu");
            Console.WriteLine("1. Make Trip");
            Console.WriteLine("2. Fill Up Fuel Tank");
            Console.WriteLine("3. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter vehicle VIN: ");
                    String vin = Console.ReadLine();
                    Console.WriteLine("Enter destination: ");
                    String destination = Console.ReadLine();

                    foreach (Vehicle vehicle in vehicles)
                    {
                        if (vehicle.vin.Equals(vin))
                        {
                            if (vehicle.makeTrip(destination))
                            {
                                Console.WriteLine("Trip successful");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient Fuel");
                            }
                        }
                    }


                    break;

                case 2:
                    Console.WriteLine("Enter vehicle VIN: ");
                    String vin2 = Console.ReadLine();

                    foreach (Vehicle vehicle in vehicles)
                    {
                        if (vehicle.vin.Equals(vin2))
                        {
                            vehicle.fillUpFuelTank();
                        }
                    }
                    break;

                default:
                    exit = true;
                    break;
            }
        }
    }
}