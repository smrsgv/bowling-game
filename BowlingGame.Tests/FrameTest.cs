using BowlingGame.Core;

namespace BowlingGame.Tests;

public class FrameTest
{
    [Fact]
    public void TestScoreNoThrows()
    {
        var frame = new Frame();

        Assert.Equal(0, frame.Score);
    }

    [Fact]
    public void TestAddOneThrow()
    {
        var frame = new Frame();

        frame.Add(5);

        Assert.Equal(5, frame.Score);
    }
}