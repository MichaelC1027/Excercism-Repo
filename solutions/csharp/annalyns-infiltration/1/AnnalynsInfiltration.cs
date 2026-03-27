static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (knightIsAwake == true) { return false; }
        return true;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        int awake = 0;
        if (!knightIsAwake && !archerIsAwake && !prisonerIsAwake) { return false; }
        if (knightIsAwake && archerIsAwake && prisonerIsAwake) { return true; }
        if (knightIsAwake) { awake++; }
        if (archerIsAwake) { awake++; }
        if (prisonerIsAwake) { awake++; }
        if (awake > 2) { return false; }

        return true;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (prisonerIsAwake)
        {
            if (archerIsAwake)
            {
                return false;
            }
            return true;
        }
        return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        int awake = 0;
        if (!knightIsAwake && !archerIsAwake && !prisonerIsAwake && petDogIsPresent) { return true; }
        if (archerIsAwake && prisonerIsAwake && petDogIsPresent) { return false; }
        if (!archerIsAwake && petDogIsPresent) { return true; }
        if (prisonerIsAwake)
        {
            awake++;
            if (petDogIsPresent) { awake--; }
            if (knightIsAwake) { awake++; }
            if (archerIsAwake) { awake++; }
            if (awake >= 2) { return false; }

            return true;
        }


        return false;
    }
}
