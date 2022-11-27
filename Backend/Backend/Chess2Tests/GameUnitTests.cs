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
}