using System.IO.Pipelines;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        var last = birdsPerDay.Length - 1;
        return birdsPerDay[last];
    }

    public void IncrementTodaysCount()
    {
        var last = birdsPerDay.Length - 1;
        birdsPerDay[last] += 1;
        Console.WriteLine(birdsPerDay[last]);
    }

    public bool HasDayWithoutBirds()
    {
        foreach (var b in birdsPerDay)
        {
            if (b == 0) { return true; }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int total = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            total += birdsPerDay[i];
        }
        return total;
    }

    public int BusyDays()
    {
        int result = 0;
        foreach (var b in birdsPerDay)
        {
            if (b >= 5) { result++; }
        }
        return result;
    }
}
