using Backend.Entities;
using Backend.Enums;
using Backend.Utilities.Factory;
using Backend.Entities.TankBuilder;

namespace Chess2Tests;

public class UnitFactoryUnitTests
{
    private UnitFactory _factory = new UnitFactory();

    [Test]
    public void GetUnits_BlueEmpty_ReturnsCorrectUnit()
    {
        // Arrange
        var color = Color.Blue;
        var map = MapType.Empty;

        // Act
        var result = _factory.GetUnits(color, map);

        // Assert
        Assert.That(result.Count, Is.EqualTo(1), "Array is of the wrong size");

        var tank = result[0];

        Assert.That(tank.CurrentHealth, Is.EqualTo(2), "Get Units Blue Empty failed");
        Assert.That(tank.MaxHealth, Is.EqualTo(2), "Get Units Blue Empty failed");
        Assert.That(tank.MovesPerTurn, Is.EqualTo(3), "Get Units Blue Empty failed");
        Assert.That(tank.IsAerial, Is.EqualTo(false), "Get Units Blue Empty failed");
        Assert.That(tank.RemainingTurns, Is.EqualTo(3), "Get Units Blue Empty failed");
        Assert.That(tank.Label, Is.EqualTo("Blue Tank"), "Get Units Blue Empty failed");
        Assert.That(tank.Damage, Is.EqualTo(1), "Get Units Blue Empty failed");
        Assert.That(tank.Color, Is.EqualTo(Color.Blue), "Get Units Blue Empty failed");
        Assert.That(tank.PosX, Is.EqualTo(10), "Get Units Blue Empty failed");
        Assert.That(tank.PosY, Is.EqualTo(18), "Get Units Blue Empty failed");
    }

    [Test]
    public void GetUnits_BluePlus_ReturnsCorrectUnit()
    {
        // Arrange
        var color = Color.Blue;
        var map = MapType.Plus;

        // Act
        var result = _factory.GetUnits(color, map);

        // Assert
        Assert.That(result.Count, Is.EqualTo(1), "Array is of the wrong size");

        var tank = result[0];

        Assert.That(tank.CurrentHealth, Is.EqualTo(2), "Get Units Blue Plus failed");
        Assert.That(tank.MaxHealth, Is.EqualTo(2), "Get Units Blue Plus failed");
        Assert.That(tank.MovesPerTurn, Is.EqualTo(3), "Get Units Blue Plus failed");
        Assert.That(tank.IsAerial, Is.EqualTo(false), "Get Units Blue Plus failed");
        Assert.That(tank.RemainingTurns, Is.EqualTo(3), "Get Units Blue Plus failed");
        Assert.That(tank.Label, Is.EqualTo("Blue Tank"), "Get Units Blue Plus failed");
        Assert.That(tank.Damage, Is.EqualTo(1), "Get Units Blue Plus failed");
        Assert.That(tank.Color, Is.EqualTo(Color.Blue), "Get Units Blue Plus failed");
        Assert.That(tank.PosX, Is.EqualTo(18), "Get Units Blue Plus failed");
        Assert.That(tank.PosY, Is.EqualTo(10), "Get Units Blue Plus failed");
    }

    [Test]
    public void GetUnits_BlueO_ReturnsCorrectUnit()
    {
        // Arrange
        var color = Color.Blue;
        var map = MapType.O;

        // Act
        var result = _factory.GetUnits(color, map);

        // Assert
        Assert.That(result.Count, Is.EqualTo(1), "Array is of the wrong size");

        var tank = result[0];

        Assert.That(tank.CurrentHealth, Is.EqualTo(2), "Get Units Blue O failed");
        Assert.That(tank.MaxHealth, Is.EqualTo(2), "Get Units Blue O failed");
        Assert.That(tank.MovesPerTurn, Is.EqualTo(3), "Get Units Blue O failed");
        Assert.That(tank.IsAerial, Is.EqualTo(false), "Get Units Blue O failed");
        Assert.That(tank.RemainingTurns, Is.EqualTo(3), "Get Units Blue O failed");
        Assert.That(tank.Label, Is.EqualTo("Blue Tank"), "Get Units Blue O failed");
        Assert.That(tank.Damage, Is.EqualTo(1), "Get Units Blue O failed");
        Assert.That(tank.Color, Is.EqualTo(Color.Blue), "Get Units Blue O failed");
        Assert.That(tank.PosX, Is.EqualTo(18), "Get Units Blue O failed");
        Assert.That(tank.PosY, Is.EqualTo(10), "Get Units Blue O failed");
    }

    [Test]
    public void GetUnits_BlueRandom_ReturnsCorrectUnit()
    {
        // Arrange
        var color = Color.Blue;
        var map = MapType.Random;

        // Act
        var result = _factory.GetUnits(color, map);

        // Assert
        Assert.That(result.Count, Is.EqualTo(1), "Array is of the wrong size");

        var tank = result[0];

        Assert.That(tank.CurrentHealth, Is.EqualTo(2), "Get Units Blue Random failed");
        Assert.That(tank.MaxHealth, Is.EqualTo(2), "Get Units Blue Random failed");
        Assert.That(tank.MovesPerTurn, Is.EqualTo(3), "Get Units Blue Random failed");
        Assert.That(tank.IsAerial, Is.EqualTo(false), "Get Units Blue Random failed");
        Assert.That(tank.RemainingTurns, Is.EqualTo(3), "Get Units Blue Random failed");
        Assert.That(tank.Label, Is.EqualTo("Blue Tank"), "Get Units Blue Random failed");
        Assert.That(tank.Damage, Is.EqualTo(1), "Get Units Blue Random failed");
        Assert.That(tank.Color, Is.EqualTo(Color.Blue), "Get Units Blue Random failed");
        Assert.That(tank.PosX, Is.EqualTo(18), "Get Units Blue Random failed");
        Assert.That(tank.PosY, Is.EqualTo(10), "Get Units Blue Random failed");
    }

        [Test]
    public void GetUnits_RedEmpty_ReturnsCorrectUnit()
    {
        // Arrange
        var color = Color.Red;
        var map = MapType.Empty;

        // Act
        var result = _factory.GetUnits(color, map);

        // Assert
        Assert.That(result.Count, Is.EqualTo(1), "Array is of the wrong size");

        var tank = result[0];

        Assert.That(tank.CurrentHealth, Is.EqualTo(2), "Get Units Red Empty failed");
        Assert.That(tank.MaxHealth, Is.EqualTo(2), "Get Units Red Empty failed");
        Assert.That(tank.MovesPerTurn, Is.EqualTo(3), "Get Units Red Empty failed");
        Assert.That(tank.IsAerial, Is.EqualTo(false), "Get Units Red Empty failed");
        Assert.That(tank.RemainingTurns, Is.EqualTo(3), "Get Units Red Empty failed");
        Assert.That(tank.Label, Is.EqualTo("Red Tank"), "Get Units Red Empty failed");
        Assert.That(tank.Damage, Is.EqualTo(1), "Get Units Red Empty failed");
        Assert.That(tank.Color, Is.EqualTo(Color.Red), "Get Units Red Empty failed");
        Assert.That(tank.PosX, Is.EqualTo(10), "Get Units Red Empty failed");
        Assert.That(tank.PosY, Is.EqualTo(1), "Get Units Red Empty failed");
    }

    [Test]
    public void GetUnits_RedPlus_ReturnsCorrectUnit()
    {
        // Arrange
        var color = Color.Red;
        var map = MapType.Plus;

        // Act
        var result = _factory.GetUnits(color, map);

        // Assert
        Assert.That(result.Count, Is.EqualTo(1), "Array is of the wrong size");

        var tank = result[0];

        Assert.That(tank.CurrentHealth, Is.EqualTo(2), "Get Units Red Plus failed");
        Assert.That(tank.MaxHealth, Is.EqualTo(2), "Get Units Red Plus failed");
        Assert.That(tank.MovesPerTurn, Is.EqualTo(3), "Get Units Red Plus failed");
        Assert.That(tank.IsAerial, Is.EqualTo(false), "Get Units Red Plus failed");
        Assert.That(tank.RemainingTurns, Is.EqualTo(3), "Get Units Red Plus failed");
        Assert.That(tank.Label, Is.EqualTo("Red Tank"), "Get Units Red Plus failed");
        Assert.That(tank.Damage, Is.EqualTo(1), "Get Units Red Plus failed");
        Assert.That(tank.Color, Is.EqualTo(Color.Red), "Get Units Red Plus failed");
        Assert.That(tank.PosX, Is.EqualTo(1), "Get Units Red Plus failed");
        Assert.That(tank.PosY, Is.EqualTo(10), "Get Units Red Plus failed");
    }

    [Test]
    public void GetUnits_RedO_ReturnsCorrectUnit()
    {
        // Arrange
        var color = Color.Red;
        var map = MapType.O;

        // Act
        var result = _factory.GetUnits(color, map);

        // Assert
        Assert.That(result.Count, Is.EqualTo(1), "Array is of the wrong size");

        var tank = result[0];

        Assert.That(tank.CurrentHealth, Is.EqualTo(2), "Get Units Red O failed");
        Assert.That(tank.MaxHealth, Is.EqualTo(2), "Get Units Red O failed");
        Assert.That(tank.MovesPerTurn, Is.EqualTo(3), "Get Units Red O failed");
        Assert.That(tank.IsAerial, Is.EqualTo(false), "Get Units Red O failed");
        Assert.That(tank.RemainingTurns, Is.EqualTo(3), "Get Units Red O failed");
        Assert.That(tank.Label, Is.EqualTo("Red Tank"), "Get Units Red O failed");
        Assert.That(tank.Damage, Is.EqualTo(1), "Get Units Red O failed");
        Assert.That(tank.Color, Is.EqualTo(Color.Red), "Get Units Red O failed");
        Assert.That(tank.PosX, Is.EqualTo(1), "Get Units Red O failed");
        Assert.That(tank.PosY, Is.EqualTo(10), "Get Units Red O failed");
    }

    [Test]
    public void GetUnits_RedRandom_ReturnsCorrectUnit()
    {
        // Arrange
        var color = Color.Red;
        var map = MapType.Random;

        // Act
        var result = _factory.GetUnits(color, map);

        // Assert
        Assert.That(result.Count, Is.EqualTo(1), "Array is of the wrong size");

        var tank = result[0];

        Assert.That(tank.CurrentHealth, Is.EqualTo(2), "Get Units Red Random failed");
        Assert.That(tank.MaxHealth, Is.EqualTo(2), "Get Units Red Random failed");
        Assert.That(tank.MovesPerTurn, Is.EqualTo(3), "Get Units Red Random failed");
        Assert.That(tank.IsAerial, Is.EqualTo(false), "Get Units Red Random failed");
        Assert.That(tank.RemainingTurns, Is.EqualTo(3), "Get Units Red Random failed");
        Assert.That(tank.Label, Is.EqualTo("Red Tank"), "Get Units Red Random failed");
        Assert.That(tank.Damage, Is.EqualTo(1), "Get Units Red Random failed");
        Assert.That(tank.Color, Is.EqualTo(Color.Red), "Get Units Red Random failed");
        Assert.That(tank.PosX, Is.EqualTo(1), "Get Units Red Random failed");
        Assert.That(tank.PosY, Is.EqualTo(10), "Get Units Red Random failed");
    }

    [Test]
    public void GetUnits_GreenEmpty_ReturnsCorrectUnit()
    {
        // Arrange
        var color = Color.Green;
        var map = MapType.Empty;

        // Act
        var result = _factory.GetUnits(color, map);

        // Assert
        Assert.That(result.Count, Is.EqualTo(1), "Array is of the wrong size");

        var tank = result[0];

        Assert.That(tank.CurrentHealth, Is.EqualTo(2), "Get Units Green Empty failed");
        Assert.That(tank.MaxHealth, Is.EqualTo(2), "Get Units Green Empty failed");
        Assert.That(tank.MovesPerTurn, Is.EqualTo(3), "Get Units Green Empty failed");
        Assert.That(tank.IsAerial, Is.EqualTo(false), "Get Units Green Empty failed");
        Assert.That(tank.RemainingTurns, Is.EqualTo(3), "Get Units Green Empty failed");
        Assert.That(tank.Label, Is.EqualTo("Green Tank"), "Get Units Green Empty failed");
        Assert.That(tank.Damage, Is.EqualTo(1), "Get Units Green Empty failed");
        Assert.That(tank.Color, Is.EqualTo(Color.Green), "Get Units Green Empty failed");
        Assert.That(tank.PosX, Is.EqualTo(1), "Get Units Green Empty failed");
        Assert.That(tank.PosY, Is.EqualTo(10), "Get Units Green Empty failed");
    }

    [Test]
    public void GetUnits_GreenPlus_ReturnsCorrectUnit()
    {
        // Arrange
        var color = Color.Green;
        var map = MapType.Plus;

        // Act
        var result = _factory.GetUnits(color, map);

        // Assert
        Assert.That(result.Count, Is.EqualTo(1), "Array is of the wrong size");

        var tank = result[0];

        Assert.That(tank.CurrentHealth, Is.EqualTo(2), "Get Units Green Plus failed");
        Assert.That(tank.MaxHealth, Is.EqualTo(2), "Get Units Green Plus failed");
        Assert.That(tank.MovesPerTurn, Is.EqualTo(3), "Get Units Green Plus failed");
        Assert.That(tank.IsAerial, Is.EqualTo(false), "Get Units Green Plus failed");
        Assert.That(tank.RemainingTurns, Is.EqualTo(3), "Get Units Green Plus failed");
        Assert.That(tank.Label, Is.EqualTo("Green Tank"), "Get Units Green Plus failed");
        Assert.That(tank.Damage, Is.EqualTo(1), "Get Units Green Plus failed");
        Assert.That(tank.Color, Is.EqualTo(Color.Green), "Get Units Green Plus failed");
        Assert.That(tank.PosX, Is.EqualTo(10), "Get Units Green Plus failed");
        Assert.That(tank.PosY, Is.EqualTo(1), "Get Units Green Plus failed");
    }

    [Test]
    public void GetUnits_GreenO_ReturnsCorrectUnit()
    {
        // Arrange
        var color = Color.Green;
        var map = MapType.O;

        // Act
        var result = _factory.GetUnits(color, map);

        // Assert
        Assert.That(result.Count, Is.EqualTo(1), "Array is of the wrong size");

        var tank = result[0];

        Assert.That(tank.CurrentHealth, Is.EqualTo(2), "Get Units Green O failed");
        Assert.That(tank.MaxHealth, Is.EqualTo(2), "Get Units Green O failed");
        Assert.That(tank.MovesPerTurn, Is.EqualTo(3), "Get Units Green O failed");
        Assert.That(tank.IsAerial, Is.EqualTo(false), "Get Units Green O failed");
        Assert.That(tank.RemainingTurns, Is.EqualTo(3), "Get Units Green O failed");
        Assert.That(tank.Label, Is.EqualTo("Green Tank"), "Get Units Green O failed");
        Assert.That(tank.Damage, Is.EqualTo(1), "Get Units Green O failed");
        Assert.That(tank.Color, Is.EqualTo(Color.Green), "Get Units Green O failed");
        Assert.That(tank.PosX, Is.EqualTo(10), "Get Units Green O failed");
        Assert.That(tank.PosY, Is.EqualTo(1), "Get Units Green O failed");
    }

    [Test]
    public void GetUnits_GreenRandom_ReturnsCorrectUnit()
    {
        // Arrange
        var color = Color.Green;
        var map = MapType.Random;

        // Act
        var result = _factory.GetUnits(color, map);

        // Assert
        Assert.That(result.Count, Is.EqualTo(1), "Array is of the wrong size");

        var tank = result[0];

        Assert.That(tank.CurrentHealth, Is.EqualTo(2), "Get Units Green Random failed");
        Assert.That(tank.MaxHealth, Is.EqualTo(2), "Get Units Green Random failed");
        Assert.That(tank.MovesPerTurn, Is.EqualTo(3), "Get Units Green Random failed");
        Assert.That(tank.IsAerial, Is.EqualTo(false), "Get Units Green Random failed");
        Assert.That(tank.RemainingTurns, Is.EqualTo(3), "Get Units Green Random failed");
        Assert.That(tank.Label, Is.EqualTo("Green Tank"), "Get Units Green Random failed");
        Assert.That(tank.Damage, Is.EqualTo(1), "Get Units Green Random failed");
        Assert.That(tank.Color, Is.EqualTo(Color.Green), "Get Units Green Random failed");
        Assert.That(tank.PosX, Is.EqualTo(10), "Get Units Green Random failed");
        Assert.That(tank.PosY, Is.EqualTo(1), "Get Units Green Random failed");
    }

    [Test]
    public void GetUnits_YellowEmpty_ReturnsCorrectUnit()
    {
        // Arrange
        var color = Color.Yellow;
        var map = MapType.Empty;

        // Act
        var result = _factory.GetUnits(color, map);

        // Assert
        Assert.That(result.Count, Is.EqualTo(1), "Array is of the wrong size");

        var tank = result[0];

        Assert.That(tank.CurrentHealth, Is.EqualTo(2), "Get Units Yellow Empty failed");
        Assert.That(tank.MaxHealth, Is.EqualTo(2), "Get Units Yellow Empty failed");
        Assert.That(tank.MovesPerTurn, Is.EqualTo(3), "Get Units Yellow Empty failed");
        Assert.That(tank.IsAerial, Is.EqualTo(false), "Get Units Yellow Empty failed");
        Assert.That(tank.RemainingTurns, Is.EqualTo(3), "Get Units Yellow Empty failed");
        Assert.That(tank.Label, Is.EqualTo("Yellow Tank"), "Get Units Yellow Empty failed");
        Assert.That(tank.Damage, Is.EqualTo(1), "Get Units Yellow Empty failed");
        Assert.That(tank.Color, Is.EqualTo(Color.Yellow), "Get Units Yellow Empty failed");
        Assert.That(tank.PosX, Is.EqualTo(18), "Get Units Yellow Empty failed");
        Assert.That(tank.PosY, Is.EqualTo(10), "Get Units Yellow Empty failed");
    }

    [Test]
    public void GetUnits_YellowPlus_ReturnsCorrectUnit()
    {
        // Arrange
        var color = Color.Yellow;
        var map = MapType.Plus;

        // Act
        var result = _factory.GetUnits(color, map);

        // Assert
        Assert.That(result.Count, Is.EqualTo(1), "Array is of the wrong size");

        var tank = result[0];

        Assert.That(tank.CurrentHealth, Is.EqualTo(2), "Get Units Yellow Plus failed");
        Assert.That(tank.MaxHealth, Is.EqualTo(2), "Get Units Yellow Plus failed");
        Assert.That(tank.MovesPerTurn, Is.EqualTo(3), "Get Units Yellow Plus failed");
        Assert.That(tank.IsAerial, Is.EqualTo(false), "Get Units Yellow Plus failed");
        Assert.That(tank.RemainingTurns, Is.EqualTo(3), "Get Units Yellow Plus failed");
        Assert.That(tank.Label, Is.EqualTo("Yellow Tank"), "Get Units Yellow Plus failed");
        Assert.That(tank.Damage, Is.EqualTo(1), "Get Units Yellow Plus failed");
        Assert.That(tank.Color, Is.EqualTo(Color.Yellow), "Get Units Yellow Plus failed");
        Assert.That(tank.PosX, Is.EqualTo(10), "Get Units Yellow Plus failed");
        Assert.That(tank.PosY, Is.EqualTo(18), "Get Units Yellow Plus failed");
    }

    [Test]
    public void GetUnits_YellowO_ReturnsCorrectUnit()
    {
        // Arrange
        var color = Color.Yellow;
        var map = MapType.O;

        // Act
        var result = _factory.GetUnits(color, map);

        // Assert
        Assert.That(result.Count, Is.EqualTo(1), "Array is of the wrong size");

        var tank = result[0];

        Assert.That(tank.CurrentHealth, Is.EqualTo(2), "Get Units Yellow O failed");
        Assert.That(tank.MaxHealth, Is.EqualTo(2), "Get Units Yellow O failed");
        Assert.That(tank.MovesPerTurn, Is.EqualTo(3), "Get Units Yellow O failed");
        Assert.That(tank.IsAerial, Is.EqualTo(false), "Get Units Yellow O failed");
        Assert.That(tank.RemainingTurns, Is.EqualTo(3), "Get Units Yellow O failed");
        Assert.That(tank.Label, Is.EqualTo("Yellow Tank"), "Get Units Yellow O failed");
        Assert.That(tank.Damage, Is.EqualTo(1), "Get Units Yellow O failed");
        Assert.That(tank.Color, Is.EqualTo(Color.Yellow), "Get Units Yellow O failed");
        Assert.That(tank.PosX, Is.EqualTo(10), "Get Units Yellow O failed");
        Assert.That(tank.PosY, Is.EqualTo(18), "Get Units Yellow O failed");
    }

    [Test]
    public void GetUnits_YellowRandom_ReturnsCorrectUnit()
    {
        // Arrange
        var color = Color.Yellow;
        var map = MapType.Random;

        // Act
        var result = _factory.GetUnits(color, map);

        // Assert
        Assert.That(result.Count, Is.EqualTo(1), "Array is of the wrong size");

        var tank = result[0];

        Assert.That(tank.CurrentHealth, Is.EqualTo(2), "Get Units Yellow Random failed");
        Assert.That(tank.MaxHealth, Is.EqualTo(2), "Get Units Yellow Random failed");
        Assert.That(tank.MovesPerTurn, Is.EqualTo(3), "Get Units Yellow Random failed");
        Assert.That(tank.IsAerial, Is.EqualTo(false), "Get Units Yellow Random failed");
        Assert.That(tank.RemainingTurns, Is.EqualTo(3), "Get Units Yellow Random failed");
        Assert.That(tank.Label, Is.EqualTo("Yellow Tank"), "Get Units Yellow Random failed");
        Assert.That(tank.Damage, Is.EqualTo(1), "Get Units Yellow Random failed");
        Assert.That(tank.Color, Is.EqualTo(Color.Yellow), "Get Units Yellow Random failed");
        Assert.That(tank.PosX, Is.EqualTo(10), "Get Units Yellow Random failed");
        Assert.That(tank.PosY, Is.EqualTo(18), "Get Units Yellow Random failed");
    }

}
