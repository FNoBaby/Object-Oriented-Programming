using System;

public class Vehicle
{
    public String vin { get; set; }
    public String make { get; set; }
    public String model { get; set; }
    public int weight { get; set; }
    public double fuelConsumption { get; set; }
    public int fuelCapacity { get; set; }
    public double fuelLevel { get; set; }

    public Vehicle() { }

    public Vehicle(String vin, String make, String model, int weight, double fuelConsumption, int fuelCapacity)
	{
        this.vin = vin;
        this.make = make;
        this.model = model;
        this.weight = weight;
        this.fuelConsumption = fuelConsumption;
        this.fuelCapacity = fuelCapacity;
        this.fuelLevel = fuelCapacity/2.0;
    }

    public void fillUpFuelTank()
    {
        fuelLevel = fuelCapacity;
    }

    public bool makeTrip(String destination)
    {
        switch (destination) { 
            case "Valletta":
                if (fuelLevel >= 8)
                {
                    fuelLevel -= 8;
                    return true;
                }
                else
                {
                    return false;
                }

            case "Sliema":
                if (fuelLevel >= 10)
                {
                    fuelLevel -= 10;
                    return true;
                }
                else
                {
                    return false;
                }

            case "Bugibba":
                if (fuelLevel >= 19)
                {
                    fuelLevel -= 19;
                    return true;
                }
                else
                {
                    return false;
                }

                default:
                return false;

        }
    }
    
    public String getData()
    {
        return " Vehicle Vin: " + vin +
            "\n Make: " + make + 
            "\n Model: " + model + 
            "\n Weight: " + weight + 
            "\n Fuel Consumption: " + fuelConsumption + 
            "\n Fuel Capacity: " + fuelCapacity + 
            "\n Fuel Level: " + fuelLevel + 
            "\n";
    }
}
