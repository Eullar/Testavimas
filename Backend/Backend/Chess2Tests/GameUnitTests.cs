using Backend.Entities;
using Backend.Enums;
using Backend.Utilities;
using Backend.Utilities.AbstractFactory;

namespace Chess2Tests;

public class Tests
{
    private Game _game;
    [SetUp]
    public void Setup()
    {
        _game = Game.GetGameInstance();
    }

    [TearDown]
    public void Teardown()
    {
        _game.Reset();
    }
    
    [Test]
    public void AddPlayer_ReturnsCorrectEnum()
    {
        // Arrange
        var player = new Player("some connection id", "PlayerBeingTested", Color.Blue, new List<Unit>());

        // Act
        var result = _game.AddPlayer(player);

        // Assert
        Assert.That(result, Is.EqualTo(AddPlayerState.Completed));
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

    [Test]
    public void AddPlayer_GameStarted_ReturnsCorrectEnum()
    {
        // Arrange
        var player1 = new Player("1", "Gin", Color.Blue, new List<Unit>());
        var initialResult1 = _game.AddPlayer(player1);
        Assert.That(initialResult1, Is.EqualTo(AddPlayerState.Completed), "Could not add intial player1");
        _game.ChangeReadyStatus("1");
        var player2 = new Player("2", "Gin2", Color.Green, new List<Unit>());
        var initialResult2 = _game.AddPlayer(player2);
        Assert.That(initialResult2, Is.EqualTo(AddPlayerState.Completed), "Could not add intial player2");
        _game.ChangeReadyStatus("2");
        var player3 = new Player("3", "Gin3", Color.Red, new List<Unit>());
        
        // Act
        var result = _game.AddPlayer(player3);
        
        // Assert
        Assert.That(result, Is.EqualTo(AddPlayerState.GameInProgress));
    }

    [Test]
    public void GenerateMap_PlusMap_ReturnsCorrectMap()
    {
        // Arrange
        _game.ChangeMap(MapType.Plus);
        var expectedMap = new PlusMapFactory().GenerateMap(new List<Player>());
        
        // Act
        var result = _game.GenerateMap();
        
        // Assert
        Assert.That(result.ToString(), Is.EqualTo(expectedMap.ToString()));
    }
    
    [Test]
    public void GenerateMap_OMap_ReturnsCorrectMap()
    {
        // Arrange
        _game.ChangeMap(MapType.O);
        var expectedMap = new OMapFactory().GenerateMap(new List<Player>());

        // Act
        var result = _game.GenerateMap();
        
        // Assert
        Assert.That(result.ToString(), Is.EqualTo(expectedMap.ToString()));
    }
    
    [Test]
    public void GenerateMap_EmptyMap_ReturnsCorrectMap()
    {
        // Arrange
        _game.ChangeMap(MapType.Empty);
        var expectedMap = new EmptyMapFactory().GenerateMap(new List<Player>());
        
        // Act
        var result = _game.GenerateMap();
        
        // Assert
        Assert.That(result.ToString(), Is.EqualTo(expectedMap.ToString()));
    }
    
    [Test]
    public void GenerateMap_RandomMap_ReturnsCorrectMap()
    {
        // Arrange
        _game.ChangeMap(MapType.Random);

        // Act
        var result = _game.GenerateMap();
        var expectedMap = _game.GetMap();
        
        // Assert
        Assert.That(result.ToString(), Is.EqualTo(expectedMap.ToString()));
    }

    [Test]
    public void RemovePlayer_RemovesPlayer()
    {
        // Arrange
        var player = new Player("1", "name", Color.Blue, new List<Unit>());
        _game.AddPlayer(player);
        Assert.That(_game.GetPlayers().Count, Is.EqualTo(1));
        
        // Act
        _game.RemovePlayer(player);
        
        // Assert
        Assert.That(_game.GetPlayers().Count, Is.EqualTo(0));
    }

    [Test]
    public void GetPlayer_WhenExists_ReturnsPlayer()
    {
        // Arrange
        var player = new Player("1", "Gin", Color.Blue, new List<Unit>());
        _game.AddPlayer(player);
        
        // Act
        var resultPlayer = _game.GetPlayerByConnectionId("1");
        
        // Assert
        Assert.That(resultPlayer.Name, Is.EqualTo(player.Name));
        Assert.That(resultPlayer.ConnectionID, Is.EqualTo(player.ConnectionID));
        Assert.That(resultPlayer.Color, Is.EqualTo(player.Color));
    }
    
    [Test]
    public void GetPlayer_WhenDoesNotExist_ReturnsNull()
    {
        // Arrange
        
        // Act
        var resultPlayer = _game.GetPlayerByConnectionId("1");
        
        // Assert
        Assert.IsNull(resultPlayer);
    }

    [Test]
    public void NextPlayer()
    {
        // Arrange
        var player1 = new Player("1", "Gin", Color.Blue, new List<Unit> { new Tank() });
        var player2 = new Player("2", "Gin2", Color.Red, new List<Unit> { new Tank() });
        _game.AddPlayer(player1);
        _game.AddPlayer(player2);
        
        // Act
        var result = _game.NextPlayer();
        
        // Assert
        Assert.That(result, Is.EqualTo(player1.ConnectionID));
    }
    [Test]
    public void NextPlayer_ChecksSecondPlayer()
    {
        // Arrange
        var player1 = new Player("1", "Gin", Color.Blue, new List<Unit> { new Tank() });
        var player2 = new Player("2", "Gin2", Color.Red, new List<Unit> { new Tank() });
        _game.AddPlayer(player1);
        _game.AddPlayer(player2);
        _game.GenerateMap();
        var firstTurn = _game.NextPlayer();
        Assert.That(firstTurn, Is.EqualTo(player1.ConnectionID));
        
        // Act
        var result = _game.NextPlayer();
        
        // Assert
        Assert.That(result, Is.EqualTo(player2.ConnectionID));
    }

    [Test]
    [TestCase(0, Color.Red)]
    [TestCase(1, Color.Blue)]
    [TestCase(2, Color.Green)]
    [TestCase(3, Color.Yellow)]
    public void GetAvailableColor_ReturnsCorrectly(int peopleCount, Color result)
    {
        // Arrange
        for (var i = 0; i < peopleCount; i++)
        {
            _game.AddPlayer(new Player($"{i}", $"TestName{i}", (Color)i, new List<Unit>()));
        }
        
        // Act
        var actualResult = _game.GetFirstAvailableFreeColor();
        
        // Assert
        Assert.That(actualResult, Is.EqualTo(result));
    }
}