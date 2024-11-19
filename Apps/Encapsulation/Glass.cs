public class Glass
{
    private int glassCapacity;
    public Glass()
    {}

    public bool refillGlassFromTank1(Machine machine)
    {
        if (machine.fillGlassFromTank1())
        {
            glassCapacity = 100;
            return true;
        }
        return false;
    }

    public bool refillGlassFromTank2(Machine machine)
    {
        if (machine.fillGlassFromTank2())
        {
            glassCapacity = 100;
            return true;
        }
        return false;
    }
    public bool isGlassFull()
    {
        return glassCapacity == 100;
    }

}