using BowlingGame.Core;

namespace BowlingGame.Tests;

public class GameTest
{
    private Game _game;

    public GameTest()
    {
        _game = new Game();
    }

    [Fact]
    public void FactTwoThrowsNoMark()
    {
        _game.Add(5);
        _game.Add(4);
        Assert.Equal(9, _game.Score);
    }

    [Fact]
    public void FactFourThrowsNoMark()
    {
        _game.Add(5);
        _game.Add(4);
        _game.Add(7);
        _game.Add(2);
        Assert.Equal(18, _game.Score);
        Assert.Equal(9, _game.ScoreForFrame(1));
        Assert.Equal(18, _game.ScoreForFrame(2));
    }

    [Fact]
    public void FactSimpleSpare()
    {
        _game.Add(3);
        _game.Add(7);
        _game.Add(3);
        Assert.Equal(13, _game.ScoreForFrame(1));
    }

    [Fact]
    public void FactSimpleFrameAfterSpare()
    {
        _game.Add(3);
        _game.Add(7);
        _game.Add(3);
        _game.Add(2);
        Assert.Equal(13, _game.ScoreForFrame(1));
        Assert.Equal(18, _game.ScoreForFrame(2));
        Assert.Equal(18, _game.Score);
    }

    [Fact]
    public void FactSimpleStrike()
    {
        _game.Add(10);
        _game.Add(3);
        _game.Add(6);
        Assert.Equal(19, _game.ScoreForFrame(1));
        Assert.Equal(28, _game.Score);
    }

    [Fact]
    public void FactPerfect_game()
    {
        for (int i = 0; i < 12; i++)
        {
            _game.Add(10);
        }

        Assert.Equal(300, _game.Score);
    }

    [Fact]
    public void FactEndOfArray()
    {
        for (int i = 0; i < 9; i++)
        {
            _game.Add(0);
            _game.Add(0);
        }

        _game.Add(2);
        _game.Add(8); // 10th frame spare
        _game.Add(10); // Strike in last position of array.
        Assert.Equal(20, _game.Score);
    }

    [Fact]
    public void FactSample_game()
    {
        _game.Add(1);
        _game.Add(4);
        _game.Add(4);
        _game.Add(5);
        _game.Add(6);
        _game.Add(4);
        _game.Add(5);
        _game.Add(5);
        _game.Add(10);
        _game.Add(0);
        _game.Add(1);
        _game.Add(7);
        _game.Add(3);
        _game.Add(6);
        _game.Add(4);
        _game.Add(10);
        _game.Add(2);
        _game.Add(8);
        _game.Add(6);
        Assert.Equal(133, _game.Score);
    }

    [Fact]
    public void FactHeartBreak()
    {
        for (int i = 0; i < 11; i++)
            _game.Add(10);
        _game.Add(9);
        Assert.Equal(299, _game.Score);
    }

    [Fact]
    public void FactTenthFrameSpare()

    {
        for (int i = 0; i < 9; i++)
            _game.Add(10);
        _game.Add(9);
        _game.Add(1);
        _game.Add(1);
        Assert.Equal(270, _game.Score);
    }
}