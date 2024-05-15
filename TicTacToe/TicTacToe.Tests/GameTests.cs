namespace TicTacToe.Tests;

public class GameTests
{
    [Fact]
    public void Move_ValidMove_ReturnsTrue()
    {
        // Arrange
        var game = new Game();

        // Act
        var result = game.Move(0, 0);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Move_InvalidMove_ReturnsFalse()
    {
        // Arrange
        var game = new Game();

        // Act
        var result1 = game.Move(-1, 0);
        var result2 = game.Move(0, -1);
        var result3 = game.Move(3, 0);
        var result4 = game.Move(0, 3);
        var result5 = game.Move(0, 0);
        var result6 = game.Move(0, 0);

        // Assert
        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
        Assert.False(result4);
        Assert.True(result5);
        Assert.False(result6);
    }

    [Fact]
    public void CheckForWin_WinningScenarioRow_ReturnsTrue()
    {
        // Arrange
        var game = new Game();

        // Act
        game.Move(0, 0);
        game.Move(1, 1);
        game.Move(0, 1);
        game.Move(1, 2);
        game.Move(0, 2);

        // Assert
        Assert.True(game.CheckForWin());
    }
    
    [Fact]
    public void CheckForWin_WinningScenarioColumn_ReturnsTrue()
    {
        // Arrange
        var game = new Game();

        // Act
        game.Move(0, 2);
        game.Move(1, 1);
        game.Move(1, 2);
        game.Move(1, 0);
        game.Move(2, 2);

        // Assert
        Assert.True(game.CheckForWin());
    }
    
    [Fact]
    public void CheckForWin_WinningScenarioDiagonal_ReturnsTrue()
    {
        // Arrange
        var game = new Game();

        // Act
        game.Move(0, 0);
        game.Move(0, 2);
        game.Move(1, 1);
        game.Move(1, 2);
        game.Move(2, 2);

        // Assert
        Assert.True(game.CheckForWin());
    }

    [Fact]
    public void CheckForWin_NoWinningScenario_ReturnsFalse()
    {
        // Arrange
        var game = new Game();

        // Act
        game.Move(0, 0);
        game.Move(1, 1);
        game.Move(0, 1);
        game.Move(1, 2);
        game.Move(2, 2);

        // Assert
        Assert.False(game.CheckForWin());
    }

    [Fact]
    public void IsBoardFull_BoardNotFull_ReturnsFalse()
    {
        // Arrange
        var game = new Game();

        // Act
        game.Move(0, 0);
        game.Move(1, 1);
        game.Move(0, 1);
        game.Move(1, 2);

        // Assert
        Assert.False(game.IsBoardFull());
    }

    [Fact]
    public void IsBoardFull_BoardFull_ReturnsTrue()
    {
        // Arrange
        var game = new Game();

        // Act
        game.Move(0, 0);
        game.Move(0, 1);
        game.Move(0, 2);
        game.Move(1, 0);
        game.Move(1, 1);
        game.Move(1, 2);
        game.Move(2, 0);
        game.Move(2, 1);
        game.Move(2, 2);

        // Assert
        Assert.True(game.IsBoardFull());
    }
}