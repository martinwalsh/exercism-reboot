using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay) => this.birdsPerDay = birdsPerDay;

    public static int[] LastWeek() => new int[] { 0, 2, 5, 3, 7, 8, 4 };

    public int Today() => this.birdsPerDay[6];

    public void IncrementTodaysCount() => this.birdsPerDay[6]++;

    public bool HasDayWithoutBirds()
    {
        foreach (int birds in this.birdsPerDay)
        {
            if (birds == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int total = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            total += this.birdsPerDay[i];
        }
        return total;
    }

    public int BusyDays()
    {
        int days = 0;
        foreach (int birds in this.birdsPerDay)
        {
            if (birds >= 5)
            {
                days++;
            }
        }
        return days;
    }
}
