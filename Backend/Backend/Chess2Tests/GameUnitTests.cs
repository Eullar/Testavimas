using Backend.Entities;
using Backend.Enums;
using Backend.Utilities;

namespace Chess2Tests;

public class Tests
{
    private Game _game;
    [SetUp]
    public void Setup()
    {
        _game = Game.GetGameInstance();
    }

    [Test]
    public void AddPlayer_PlayerWithNameAlreadyExists_ReturnsCorrectEnum()
    {
        // Arrange
        var player = new Player("some connection id", "PlayerBeingTested", Color.Blue, new List<Unit>());
        var initialResult = _game.AddPlayer(player);
        Assert.That(initialResult, Is.EqualTo(AddPlayerState.Completed), "Could not add intial player");

        // Act
        var result = _game.AddPlayer(player);

        // Assert
        Assert.That(result, Is.EqualTo(AddPlayerState.PlayerWithNameExists));
    }

    [Test]
    public void AddPlayer_ServerIsFull_ReturnsCorrectEnum()
    {
        // Arrange
        var player1 = new Player("some connection id1", "PlayerBeingTested1", Color.Blue, new List<Unit>());
        var player2 = new Player("some connection id2", "PlayerBeingTested2", Color.Red, new List<Unit>());
        var player3 = new Player("some connection id3", "PlayerBeingTested3", Color.Yellow, new List<Unit>());
        var player4 = new Player("some connection id4", "PlayerBeingTested4", Color.Green, new List<Unit>());
        var player5 = new Player("some connection id5", "PlayerBeingTested5", Color.Green, new List<Unit>());

        var initialResult1 = _game.AddPlayer(player1);
        Assert.That(initialResult1, Is.EqualTo(AddPlayerState.Completed), "Could not add intial player 1");

        var initialResult2 = _game.AddPlayer(player2);
        Assert.That(initialResult2, Is.EqualTo(AddPlayerState.Completed), "Could not add intial player 2");

        var initialResult3 = _game.AddPlayer(player3);
        Assert.That(initialResult3, Is.EqualTo(AddPlayerState.Completed), "Could not add intial player 3");

        var initialResult4 = _game.AddPlayer(player4);
        Assert.That(initialResult4, Is.EqualTo(AddPlayerState.Completed), "Could not add intial player 4");

        // Act
        var result = _game.AddPlayer(player5);

        // Assert
        Assert.That(result, Is.EqualTo(AddPlayerState.ServerIsFull));
    }
}