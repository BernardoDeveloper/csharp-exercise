static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
        if (knightIsAwake)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        // throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
        if (knightIsAwake || archerIsAwake || prisonerIsAwake)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        // throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
        if (!archerIsAwake && prisonerIsAwake)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        // throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");

        if (petDogIsPresent && !archerIsAwake && prisonerIsAwake)
        {
            return true;
        }
        else if (!petDogIsPresent && prisonerIsAwake && !archerIsAwake && !knightIsAwake)
        {
            return true;
        }
        else if (petDogIsPresent && !prisonerIsAwake && !archerIsAwake && !knightIsAwake)
        {
            return true;
        }
        else if (petDogIsPresent && knightIsAwake && !prisonerIsAwake && !archerIsAwake)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
