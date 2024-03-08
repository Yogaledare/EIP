namespace EIP.Tests;

using Xunit;
using EIP._3._3_3._4_InheritencePolymorphism;

public class AnimalTests {
    [Fact]
    public void Horse_Initialization_ShouldSetPropertiesCorrectly() {
        // Arrange
        var horse = new Horse(5, 500, "Starlight", true);

        // Assert
        Assert.Equal(5, horse.Age);
        Assert.Equal(500, horse.Weight);
        Assert.Equal("Starlight", horse.Name);
        Assert.True(horse.IsWhite);
    }


    [Fact]
    public void Dog_DoSound_ShouldOutputExpectedSound() {
        // Arrange

        TextWriter originalOut = Console.Out;
        var dog = new Dog(3, 30, "Buddy", "Labrador");
        using (var sw = new StringWriter()) {
            Console.SetOut(sw);
            // Act
            dog.DoSound();

            // Assert
            var expected = "Woof\r\n";
            Assert.Equal(expected, sw.ToString());
        }

        Console.SetOut(originalOut);
    }


    [Fact]
    public void Bird_Stats_ShouldReturnExpectedString() {
        // Arrange
        var bird = new Bird(2, 0.5, "Tweety", "Yellow");

        // Act
        var stats = bird.Stats();

        // Assert
        Assert.Contains("Age: 2", stats);
        Assert.Contains("Weight: 0,5", stats);
        Assert.Contains("Name: Tweety", stats);
        Assert.Contains("Color: Yellow", stats);
    }
}