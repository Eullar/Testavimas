using Backend.Entities;
using Backend.Enums;
using Backend.Utilities.Factory;
using Backend.Entities.TankBuilder;

namespace Chess2Tests;

public class UnitDecoratorUnitTests
{
    [Test]
    public void UnitBlueDecorator_DecorateTank_CorrectlyDecorated()
    {
        // Arrange
        var newUnit = new Tank
        {
            Color = Color.Blue
        };

        var builder = new TankBuilder(newUnit);
        var tank = Director.ConstructTank(builder, 10, 10);
        Assert.That(tank.Label, Is.EqualTo("Tank"), "Initial tank creation failed");

        // Act
        var result = new UnitBlueDecorator(tank);

        // Assert
        Assert.That(result.Label, Is.EqualTo("Blue Tank"), "Blue Tank decoration failed");
    }

    [Test]
    public void UnitRedDecorator_DecorateTank_CorrectlyDecorated()
    {
        // Arrange
        var newUnit = new Tank
        {
            Color = Color.Red
        };

        var builder = new TankBuilder(newUnit);
        var tank = Director.ConstructTank(builder, 10, 10);
        Assert.That(tank.Label, Is.EqualTo("Tank"), "Initial tank creation failed");

        // Act
        var result = new UnitRedDecorator(tank);

        // Assert
        Assert.That(result.Label, Is.EqualTo("Red Tank"), "Red Tank decoration failed");
    }


    [Test]
    public void UnitYellowDecorator_DecorateTank_CorrectlyDecorated()
    {
        // Arrange
        var newUnit = new Tank
        {
            Color = Color.Yellow
        };

        var builder = new TankBuilder(newUnit);
        var tank = Director.ConstructTank(builder, 10, 10);
        Assert.That(tank.Label, Is.EqualTo("Tank"), "Initial tank creation failed");

        // Act
        var result = new UnitYellowDecorator(tank);

        // Assert
        Assert.That(result.Label, Is.EqualTo("Yellow Tank"), "Yellow Tank decoration failed");
    }

    [Test]
    public void UnitGreenDecorator_DecorateTank_CorrectlyDecorated()
    {
        // Arrange
        var newUnit = new Tank
        {
            Color = Color.Green
        };

        var builder = new TankBuilder(newUnit);
        var tank = Director.ConstructTank(builder, 10, 10);
        Assert.That(tank.Label, Is.EqualTo("Tank"), "Initial tank creation failed");

        // Act
        var result = new UnitGreenDecorator(tank);

        // Assert
        Assert.That(result.Label, Is.EqualTo("Green Tank"), "Green Tank decoration failed");
    }

    [Test]
    public void UnitDamageDecorator_DecorateTank_CorrectlyDecorated()
    {
        // Arrange
        var newUnit = new Tank
        {
            Color = Color.Blue
        };

        var builder = new TankBuilder(newUnit);
        var tank = Director.ConstructTank(builder, 10, 10);
        Assert.That(tank.Label, Is.EqualTo("Tank"), "Initial tank creation failed");

        // Act
        var result = new UnitDamageDecorator(tank);

        // Assert
        Assert.That(result.Label, Is.EqualTo("D Tank"), "Damaged Tank decoration failed");
    }

    [Test]
    public void UnitHealDecorator_DecorateTank_CorrectlyDecorated()
    {
        // Arrange
        var newUnit = new Tank
        {
            Color = Color.Blue
        };

        var builder = new TankBuilder(newUnit);
        var tank = Director.ConstructTank(builder, 10, 10);
        Assert.That(tank.Label, Is.EqualTo("Tank"), "Initial tank creation failed");

        // Act
        var result = new UnitHealDecorator(tank);

        // Assert
        Assert.That(result.Label, Is.EqualTo("H Tank"), "Healed Tank decoration failed");
    }

    [Test]
    public void UnitBlueHealDecorator_DecorateTankTwice_CorrectlyDecorated()
    {
        // Arrange
        var newUnit = new Tank
        {
            Color = Color.Blue
        };

        var builder = new TankBuilder(newUnit);
        var tank = Director.ConstructTank(builder, 10, 10);
        Assert.That(tank.Label, Is.EqualTo("Tank"), "Initial tank creation failed");

        // Act
        var result = new UnitBlueDecorator(new UnitHealDecorator(tank));

        // Assert
        Assert.That(result.Label, Is.EqualTo("Blue H Tank"), "Blue Healed Tank decoration failed");
    }

    [Test]
    public void UnitDamageRedDecorator_DecorateTankTwice_CorrectlyDecorated()
    {
        // Arrange
        var newUnit = new Tank
        {
            Color = Color.Blue
        };

        var builder = new TankBuilder(newUnit);
        var tank = Director.ConstructTank(builder, 10, 10);
        Assert.That(tank.Label, Is.EqualTo("Tank"), "Initial tank creation failed");

        // Act
        var result = new UnitDamageDecorator (new UnitRedDecorator(tank));

        // Assert
        Assert.That(result.Label, Is.EqualTo("D Red Tank"), "Healed Tank decoration failed");
    }
}