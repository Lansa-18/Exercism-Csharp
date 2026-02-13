public class Player
{
    public int RollDie() => new Random().Next(1, 19);

    public double GenerateSpellStrength()
    {
        double randomNumber = new Random().NextDouble() * 100;
        return randomNumber;
    }
}
