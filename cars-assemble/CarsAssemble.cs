static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double result = 0.0;
        if (speed >= 1 && speed <= 4)
            result = 1;
        else if (speed >= 5 && speed <= 8)
            result = 0.9;
        else if (speed == 9)
            result = 0.8;
        else if (speed == 10)
            result = 0.77;
        else result = 0;

        return result;
        throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double rate = SuccessRate(speed);
        int producePerHour = speed * 221;
        return producePerHour * rate;
        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        /*
            - In 1hr at speed (1), 3.68 cars are produced
            - Therefore at speed (6) -> 6 * 3.68 cars are produced which is 22.08
            - Multiplied by the success rate of that particular speed -> 22.08 * 0.9 gives 19.872 (19 when type casted.
        */

        double producePerMin = speed * 3.68;
        double rate = SuccessRate(speed);
        return (int) (producePerMin * rate);

        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
