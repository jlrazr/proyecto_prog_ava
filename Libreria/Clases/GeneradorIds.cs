using System;

public class GeneradorIds
{
    private static readonly Random random = new Random();

    public static int GenerarID()
    {
        int minID = 1;
        int maxID = 9999999;

        int randomID = random.Next(minID, maxID + 1);

        return randomID;
    }
}
