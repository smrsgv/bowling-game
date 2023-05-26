namespace BowlingGame.Core;

public class Frame
{
    public int Score { get; private set; }

    public void Add(int pins)
    {
        Score += pins;
    }
}