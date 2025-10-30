class BirdCount
{
    private int[] birdsPerDay;
    public int todayCount;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
        todayCount = birdsPerDay.Length - 1;
    }

    public static int[] LastWeek()
    {
        int[] lastWeekData = { 0, 2, 5, 3, 7, 8, 4 };
        return lastWeekData;
        throw new NotImplementedException("Please implement the (static) BirdCount.LastWeek() method");
    }

    public int Today()
    {
        return birdsPerDay[todayCount];
        throw new NotImplementedException("Please implement the BirdCount.Today() method");
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[todayCount] = birdsPerDay[todayCount] + 1;
    }

    public bool HasDayWithoutBirds()
    {
        int count = 0;
        for (int i = 0; i < birdsPerDay.Length; i++)
        {
            if (birdsPerDay[i] == 0)
            {
                count += 1;
            }
        }

        return count >= 1 ? true : false;
        throw new NotImplementedException("Please implement the BirdCount.HasDayWithoutBirds() method");
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            sum += birdsPerDay[i];
        }
        return sum;
        throw new NotImplementedException("Please implement the BirdCount.CountForFirstDays() method");
    }

    public int BusyDays()
    {
        int count = 0;
        for (int i = 0; i < birdsPerDay.Length; i++)
        {
            if (birdsPerDay[i] >= 5)
                count += 1;
        }

        return count;
        throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
    }
}
