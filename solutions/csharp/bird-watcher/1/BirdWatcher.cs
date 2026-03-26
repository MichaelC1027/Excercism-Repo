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
        int[] bpd = birdsPerDay;
        var last = bpd.Length - 1;
        return bpd[last];
        //throw new NotImplementedException("Please implement the BirdCount.Today() method");
    }

    public void IncrementTodaysCount()
    {
        int[] bpd = birdsPerDay;
        var last = bpd.Length - 1;
        bpd[last] += 1;
        Console.WriteLine(bpd[last]);
        //throw new NotImplementedException("Please implement the BirdCount.IncrementTodaysCount() method");
    }

    public bool HasDayWithoutBirds()
    {
        int[] bpd = birdsPerDay;
        foreach (var b in bpd)
        {
            if (b == 0) { return true; }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int[] bpd = birdsPerDay;
        int total = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            total += bpd[i];
        }
        return total;
    }

    public int BusyDays()
    {
        int[] bpd = birdsPerDay;
        int result = 0;
        foreach (var b in bpd)
        {
            if (b >= 5) { result++; }
        }
        return result;
    }
}


// class Program
// {
//     public static void Main(String[] args)
//     {
//         int[] birdsPerDay = {2,5,0,7,4,1};
//         BirdCount bc = new BirdCount(birdsPerDay);
//         bc.LastWeek();
//     }
// }
