using Backend.Entities;
using Backend.Utilities.AbstractFactory;
using System.Text.RegularExpressions;

namespace Chess2Tests;

public class MapFactoryTests
{
    [Test]
    public void EmptyMapFactory_GenerateMap_GeneratesCorrectMap() {
        // Arrange
        var factory = new EmptyMapFactory();

        var pattern = @"X{20}\n(X {18}X\n){18}X{20}";
        var regex = new Regex(pattern);

        // Act
        var map = factory.GenerateMap(new List<Player>()).ToString();
        var matches = regex.IsMatch(map);

        // Assert
        Assert.That(matches, Is.EqualTo(true), "Empty Map Failed");
    }

    [Test]
    public void PlusMapFactory_GenerateMap_GeneratesCorrectMap() {
        // Arrange
        var factory = new PlusMapFactory();

        var pattern = @"X{20}\n(X{7} {6}X{7}\n){6}(X {18}X\n){6}(X{7} {6}X{7}\n){6}X{20}";
        var regex = new Regex(pattern);

        // Act
        var map = factory.GenerateMap(new List<Player>()).ToString();
        var matches = regex.IsMatch(map);

        // Assert
        Assert.That(matches, Is.EqualTo(true), "Plus Map failed");
    }

    [Test]
    public void OMapFactory_GenerateMap_GeneratesCorrectMap() {
        // Arrange
        var factory = new OMapFactory();

        var pattern = @"X{20}\n(X {18}X\n){4}(X {4}X{10} {4}X\n){10}(X {18}X\n){4}X{20}";
        var regex = new Regex(pattern);

        // Act
        var map = factory.GenerateMap(new List<Player>()).ToString();
        var matches = regex.IsMatch(map);

        // Assert
        Assert.That(matches, Is.EqualTo(true), "O Map failed");
    }

    [Test]
    public void RandomMapFactory_GenerateMap_GeneratesCorrectMap() {
        // Arrange
        var factory = new RandomMapFactory();

        var pattern = @"X{20}\n(X {18}X\n){2}(X  [ X]{14}  X\n){14}(X {18}X\n){2}X{20}";
        var regex = new Regex(pattern);

        // Act
        var map = factory.GenerateMap(new List<Player>()).ToString();
        var matches = regex.IsMatch(map);

        // Assert
        Assert.That(matches, Is.EqualTo(true), "Random Map failed");
    }
}
