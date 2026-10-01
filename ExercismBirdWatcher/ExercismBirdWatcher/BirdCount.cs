namespace ExercismBirdWatcher;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return [0, 2, 5, 3, 7, 8, 4];
    }

    public int Today()
    {
        return birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int noBirds in birdsPerDay)
        {
            if (noBirds == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        byte total = 0;
        for (int i = 0; i < Math.Min(numberOfDays, birdsPerDay.Length); i++)
        {
            total += (byte)birdsPerDay[i];
        }
        return total;
    }

    public int BusyDays()
    {
        byte count = default;
        foreach (int birds in birdsPerDay)
        {
            if (birds >= 5)
            {
                count++;
            }
        }
        return count;
    }
}
