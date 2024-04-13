using System;

public class Player
{
    private static Random random = new Random();

    public int RollDie()
    {
        return random.Next(1, 7);
    }

    public double GenerateSpellStrength()
    {
        return random.NextDouble() * 100;
    }
}
