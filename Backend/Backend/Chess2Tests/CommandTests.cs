using Backend.Entities;
using Backend.Enums;
using Backend.Utilities;
using Backend.Utilities.Command;

namespace Chess2Tests;

public class CommandTests
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
    public void Execute_MoveRight_MovesCorrectly()
    {
        // Arrange
        var command = new MoveRightCommand();

        var player1 = new Player("some connection id1", "PlayerBeingTested1", Color.Blue, new List<Unit>());
        var player2 = new Player("some connection id2", "PlayerBeingTested2", Color.Red, new List<Unit>());

        _game.AddPlayer(player1);
        _game.AddPlayer(player2);

        _game.ChangeMap(MapType.O);
        _game.GenerateMap();

        var map = _game.GetMap();

        var unit = _game.GetPlayerByConnectionId("some connection id2")?.Units.First();

        // Act
        Assert.IsNotNull(unit, "Null unit");

        var result = command.Execute(unit, map, _game);

        // Assert
        Assert.That(result, Is.EqualTo(2), "Movement Failed");
        var movedUnit = _game.GetPlayerByConnectionId("some connection id2")?.Units.First();

        Assert.IsNotNull(movedUnit, "Null unit");
        Assert.That(movedUnit.PosX, Is.EqualTo(2), "Movement Failed");
    }

    [Test]
    public void Execute_MoveLeft_WallPreventsMovement()
    {
        // Arrange
        var command = new MoveLeftCommand();

        var player1 = new Player("some connection id1", "PlayerBeingTested1", Color.Blue, new List<Unit>());
        var player2 = new Player("some connection id2", "PlayerBeingTested2", Color.Red, new List<Unit>());

        _game.AddPlayer(player1);
        _game.AddPlayer(player2);

        _game.ChangeMap(MapType.O);
        _game.GenerateMap();

        var map = _game.GetMap();

        var unit = _game.GetPlayerByConnectionId("some connection id2")?.Units.First();

        // Act
        Assert.IsNotNull(unit, "Null unit");

        var result = command.Execute(unit, map, _game);

        // Assert
        Assert.That(result, Is.EqualTo(3), "Movement Failed");
        var movedUnit = _game.GetPlayerByConnectionId("some connection id2")?.Units.First();

        Assert.IsNotNull(movedUnit, "Null unit");
        Assert.That(movedUnit.PosX, Is.EqualTo(1), "Movement Failed");
    }

    [Test]
    public void Execute_MoveLeft_MovesCorrectly()
    {
        // Arrange
        var command = new MoveLeftCommand();

        var player1 = new Player("some connection id1", "PlayerBeingTested1", Color.Blue, new List<Unit>());
        var player2 = new Player("some connection id2", "PlayerBeingTested2", Color.Red, new List<Unit>());

        _game.AddPlayer(player1);
        _game.AddPlayer(player2);

        _game.ChangeMap(MapType.O);
        _game.GenerateMap();

        var map = _game.GetMap();

        var unit = _game.GetPlayerByConnectionId("some connection id1")?.Units.First();

        // Act
        Assert.IsNotNull(unit, "Null unit");

        var result = command.Execute(unit, map, _game);

        // Assert
        Assert.That(result, Is.EqualTo(2), "Movement Failed");
        var movedUnit = _game.GetPlayerByConnectionId("some connection id1")?.Units.First();

        Assert.IsNotNull(movedUnit, "Null unit");
        Assert.That(movedUnit.PosX, Is.EqualTo(17), "Movement Failed");
    }

    [Test]
    public void Execute_MoveRight_WallPreventsMovement()
    {
        // Arrange
        var command = new MoveRightCommand();

        var player1 = new Player("some connection id1", "PlayerBeingTested1", Color.Blue, new List<Unit>());
        var player2 = new Player("some connection id2", "PlayerBeingTested2", Color.Red, new List<Unit>());

        _game.AddPlayer(player1);
        _game.AddPlayer(player2);

        _game.ChangeMap(MapType.O);
        _game.GenerateMap();

        var map = _game.GetMap();

        var unit = _game.GetPlayerByConnectionId("some connection id1")?.Units.First();

        // Act
        Assert.IsNotNull(unit, "Null unit");

        var result = command.Execute(unit, map, _game);

        // Assert
        Assert.That(result, Is.EqualTo(3), "Movement Failed");
        var movedUnit = _game.GetPlayerByConnectionId("some connection id1")?.Units.First();

        Assert.IsNotNull(movedUnit, "Null unit");
        Assert.That(movedUnit.PosX, Is.EqualTo(18), "Movement Failed");
    }

    [Test]
    public void Execute_MoveUp_MovesCorrectly()
    {
        // Arrange
        var command = new MoveUpCommand();

        var player1 = new Player("some connection id1", "PlayerBeingTested1", Color.Green, new List<Unit>());
        var player2 = new Player("some connection id2", "PlayerBeingTested2", Color.Yellow, new List<Unit>());

        _game.AddPlayer(player1);
        _game.AddPlayer(player2);

        _game.ChangeMap(MapType.O);
        _game.GenerateMap();

        var map = _game.GetMap();

        var unit = _game.GetPlayerByConnectionId("some connection id2")?.Units.First();

        // Act
        Assert.IsNotNull(unit, "Null unit");

        var result = command.Execute(unit, map, _game);

        // Assert
        Assert.That(result, Is.EqualTo(2), "Movement Failed");
        var movedUnit = _game.GetPlayerByConnectionId("some connection id2")?.Units.First();

        Assert.IsNotNull(movedUnit, "Null unit");
        Assert.That(movedUnit.PosY, Is.EqualTo(17), "Movement Failed");
    }

    [Test]
    public void Execute_MoveDown_WallPreventsMovement()
    {
        // Arrange
        var command = new MoveDownCommand();

        var player1 = new Player("some connection id1", "PlayerBeingTested1", Color.Green, new List<Unit>());
        var player2 = new Player("some connection id2", "PlayerBeingTested2", Color.Yellow, new List<Unit>());

        _game.AddPlayer(player1);
        _game.AddPlayer(player2);

        _game.ChangeMap(MapType.O);
        _game.GenerateMap();

        var map = _game.GetMap();

        var unit = _game.GetPlayerByConnectionId("some connection id2")?.Units.First();

        // Act
        Assert.IsNotNull(unit, "Null unit");

        var result = command.Execute(unit, map, _game);

        // Assert
        Assert.That(result, Is.EqualTo(3), "Movement Failed");
        var movedUnit = _game.GetPlayerByConnectionId("some connection id2")?.Units.First();

        Assert.IsNotNull(movedUnit, "Null unit");
        Assert.That(movedUnit.PosY, Is.EqualTo(18), "Movement Failed");
    }

    [Test]
    public void Execute_MoveDown_MovesCorrectly()
    {
        // Arrange
        var command = new MoveDownCommand();

        var player1 = new Player("some connection id1", "PlayerBeingTested1", Color.Green, new List<Unit>());
        var player2 = new Player("some connection id2", "PlayerBeingTested2", Color.Yellow, new List<Unit>());

        _game.AddPlayer(player1);
        _game.AddPlayer(player2);

        _game.ChangeMap(MapType.O);
        _game.GenerateMap();

        var map = _game.GetMap();

        var unit = _game.GetPlayerByConnectionId("some connection id1")?.Units.First();

        // Act
        Assert.IsNotNull(unit, "Null unit");

        var result = command.Execute(unit, map, _game);

        // Assert
        Assert.That(result, Is.EqualTo(2), "Movement Failed");
        var movedUnit = _game.GetPlayerByConnectionId("some connection id1")?.Units.First();

        Assert.IsNotNull(movedUnit, "Null unit");
        Assert.That(movedUnit.PosY, Is.EqualTo(2), "Movement Failed");
    }

    [Test]
    public void Execute_MoveUp_WallPreventsMovement()
    {
        // Arrange
        var command = new MoveUpCommand();

        var player1 = new Player("some connection id1", "PlayerBeingTested1", Color.Green, new List<Unit>());
        var player2 = new Player("some connection id2", "PlayerBeingTested2", Color.Yellow, new List<Unit>());

        _game.AddPlayer(player1);
        _game.AddPlayer(player2);

        _game.ChangeMap(MapType.O);
        _game.GenerateMap();

        var map = _game.GetMap();

        var unit = _game.GetPlayerByConnectionId("some connection id1")?.Units.First();

        // Act
        Assert.IsNotNull(unit, "Null unit");

        var result = command.Execute(unit, map, _game);

        // Assert
        Assert.That(result, Is.EqualTo(3), "Movement Failed");
        var movedUnit = _game.GetPlayerByConnectionId("some connection id1")?.Units.First();

        Assert.IsNotNull(movedUnit, "Null unit");
        Assert.That(movedUnit.PosY, Is.EqualTo(1), "Movement Failed");
    }
}
