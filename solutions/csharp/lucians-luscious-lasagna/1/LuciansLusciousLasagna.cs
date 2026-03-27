class Lasagna
{

    int ovenTime;

    public Lasagna()
    {
        ovenTime = 40;
    }

    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return ovenTime;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int timeSpent)
    {
        int result = ovenTime - timeSpent;
        return result;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int timeSpent)
    {
        int prep = PreparationTimeInMinutes(layers);
        return prep + timeSpent;
    }
}
