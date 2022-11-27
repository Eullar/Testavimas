using Backend.Entities.TankBuilder;
using Backend.Entities;
using Backend.Enums;

namespace Chess2Tests;

public class DirectorUnitTests
{
    [Test]
    public void ConstructTank_BlueTankBuilderAtX10Y10_ReturnsValidTank()
    {
        // Arrange

        var newUnit = new Tank
        {
            Color = Color.Blue
        };

        var builder = new TankBuilder(newUnit);

        // Act
        var result = Director.ConstructTank(builder, 10, 10);

        // Assert
        Assert.That(result.CurrentHealth, Is.EqualTo(2), "Blue tank at 10,10 failed");
        Assert.That(result.MaxHealth, Is.EqualTo(2), "Blue tank at 10,10 failed");
        Assert.That(result.MovesPerTurn, Is.EqualTo(3), "Blue tank at 10,10 failed");
        Assert.That(result.IsAerial, Is.EqualTo(false), "Blue tank at 10,10 failed");
        Assert.That(result.RemainingTurns, Is.EqualTo(3), "Blue tank at 10,10 failed");
        Assert.That(result.Label, Is.EqualTo("Tank"), "Blue tank at 10,10 failed");
        Assert.That(result.Damage, Is.EqualTo(1), "Blue tank at 10,10 failed");
        Assert.That(result.Color, Is.EqualTo(Color.Blue), "Blue tank at 10,10 failed");
        Assert.That(result.PosX, Is.EqualTo(10), "Blue tank at 10,10 failed");
        Assert.That(result.PosY, Is.EqualTo(10), "Blue tank at 10,10 failed");
    }
    
    [Test]
    public void ConstructTank_GreenTankBuilderAtX1Y10_ReturnsValidTank()
    {
        // Arrange

        var newUnit = new Tank
        {
            Color = Color.Green
        };

        var builder = new TankBuilder(newUnit);

        // Act
        var result = Director.ConstructTank(builder, 1, 10);

        // Assert
        Assert.That(result.CurrentHealth, Is.EqualTo(2), "Green tank at 10,10 failed");
        Assert.That(result.MaxHealth, Is.EqualTo(2), "Green tank at 10,10 failed");
        Assert.That(result.MovesPerTurn, Is.EqualTo(3), "Green tank at 10,10 failed");
        Assert.That(result.IsAerial, Is.EqualTo(false), "Green tank at 10,10 failed");
        Assert.That(result.RemainingTurns, Is.EqualTo(3), "Green tank at 10,10 failed");
        Assert.That(result.Label, Is.EqualTo("Tank"), "Green tank at 10,10 failed");
        Assert.That(result.Damage, Is.EqualTo(1), "Green tank at 10,10 failed");
        Assert.That(result.Color, Is.EqualTo(Color.Green), "Green tank at 10,10 failed");
        Assert.That(result.PosX, Is.EqualTo(1), "Green tank at 10,10 failed");
        Assert.That(result.PosY, Is.EqualTo(10), "Green tank at 10,10 failed");
    }

    [Test]
    public void ConstructTank_YellowTankBuilderAtX18Y6_ReturnsValidTank()
    {
        // Arrange

        var newUnit = new Tank
        {
            Color = Color.Yellow
        };

        var builder = new TankBuilder(newUnit);

        // Act
        var result = Director.ConstructTank(builder, 18, 6);

        // Assert
        Assert.That(result.CurrentHealth, Is.EqualTo(2), "Yellow tank at 10,10 failed");
        Assert.That(result.MaxHealth, Is.EqualTo(2), "Yellow tank at 10,10 failed");
        Assert.That(result.MovesPerTurn, Is.EqualTo(3), "Yellow tank at 10,10 failed");
        Assert.That(result.IsAerial, Is.EqualTo(false), "Yellow tank at 10,10 failed");
        Assert.That(result.RemainingTurns, Is.EqualTo(3), "Yellow tank at 10,10 failed");
        Assert.That(result.Label, Is.EqualTo("Tank"), "Yellow tank at 10,10 failed");
        Assert.That(result.Damage, Is.EqualTo(1), "Yellow tank at 10,10 failed");
        Assert.That(result.Color, Is.EqualTo(Color.Yellow), "Yellow tank at 10,10 failed");
        Assert.That(result.PosX, Is.EqualTo(18), "Yellow tank at 10,10 failed");
        Assert.That(result.PosY, Is.EqualTo(6), "Yellow tank at 10,10 failed");
    }

    [Test]
    public void ConstructTank_RedTankBuilderAtX1Y1_ReturnsValidTank()
    {
        // Arrange

        var newUnit = new Tank
        {
            Color = Color.Red
        };

        var builder = new TankBuilder(newUnit);

        // Act
        var result = Director.ConstructTank(builder, 1, 1);

        // Assert
        Assert.That(result.CurrentHealth, Is.EqualTo(2), "Red tank at 10,10 failed");
        Assert.That(result.MaxHealth, Is.EqualTo(2), "Red tank at 10,10 failed");
        Assert.That(result.MovesPerTurn, Is.EqualTo(3), "Red tank at 10,10 failed");
        Assert.That(result.IsAerial, Is.EqualTo(false), "Red tank at 10,10 failed");
        Assert.That(result.RemainingTurns, Is.EqualTo(3), "Red tank at 10,10 failed");
        Assert.That(result.Label, Is.EqualTo("Tank"), "Red tank at 10,10 failed");
        Assert.That(result.Damage, Is.EqualTo(1), "Red tank at 10,10 failed");
        Assert.That(result.Color, Is.EqualTo(Color.Red), "Red tank at 10,10 failed");
        Assert.That(result.PosX, Is.EqualTo(1), "Red tank at 10,10 failed");
        Assert.That(result.PosY, Is.EqualTo(1), "Red tank at 10,10 failed");
    }
}