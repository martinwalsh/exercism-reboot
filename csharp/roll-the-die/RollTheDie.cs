using System;

public class Player
{
    private static Random random = new Random();

    public int RollDie() => random.Next(1, 7);

    public double GenerateSpellStrength() => random.NextDouble() * 100;
}
