class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int speed;
    private int batteryDrain;
    public int distanceCovered;
    public int batteryCharge = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        if (batteryCharge >= batteryDrain)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public int DistanceDriven() => distanceCovered;

    public void Drive()
    {
        bool hasBatteryDrained = BatteryDrained();
        if (!hasBatteryDrained)
        {
            distanceCovered += speed;
            batteryCharge -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }

    public int GetBatteryDrain() => batteryDrain;

    public int GetSpeed() => speed;
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int batteryDrain = car.GetBatteryDrain();
        int speed = car.GetSpeed();
        int maxDrives = car.batteryCharge / batteryDrain;
        int maxDistance = speed * maxDrives;

        return maxDistance >= distance;
    }
}
