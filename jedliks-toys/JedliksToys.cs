class RemoteControlCar
{
    public int _distanceDriven = 0;
    public int _batteryHealth = 100;

    public static RemoteControlCar Buy()
    {
        RemoteControlCar car = new RemoteControlCar();
        return car;
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Buy() method");
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distanceDriven} meters";
        throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDisplay() method");
    }

    public string BatteryDisplay()
    {
        if (_batteryHealth <= 0)
            return $"Battery empty";
        else return $"Battery at {_batteryHealth}%";
        throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDisplay() method");
    }

    public void Drive()
    {
        if (_batteryHealth > 0)
        {
            _distanceDriven += 20;
            _batteryHealth -= 1;
        }
    }
}
