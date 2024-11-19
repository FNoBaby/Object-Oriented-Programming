public class Machine
{
    private int tank1;
    private int tank2;

    public Machine() { }

    public void refillTank1()
    {
        tank1 = 1000;
    }

    public void refillTank2()
    {
        tank2 = 1000;
    }

    public bool fillGlassFromTank1()
    {
        if (tank1 >= 100)
        {
            tank1 -= 100;
            return true;
        }
        return false;
    }

    public bool fillGlassFromTank2()
    {
        if (tank2 >= 100)
        {
            tank2 -= 100;
            return true;
        }
        return false;
    }

    public TankLevelEnums getLevelTank1()
    {
        return getLevelTank(tank1);
    }


    public TankLevelEnums getLevelTank2()
    {
        return getLevelTank(tank2);

    }

    private TankLevelEnums getLevelTank(int tank)
    {
        if (tank == 0)
        {
            return TankLevelEnums.EMPTY;
        }
        else if (tank < 250)
        {
            return TankLevelEnums.LOW;
        }
        else if (tank < 500)
        {
            return TankLevelEnums.MEDIUM;
        }
        else if (tank < 750)
        {
            return TankLevelEnums.HIGH;
        }
        else
        {
            return TankLevelEnums.FULL;
        }
    }
}