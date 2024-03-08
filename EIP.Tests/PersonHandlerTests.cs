namespace EIP.Tests;

using Xunit;
using EIP._3._1_Encapsulation;

public class PersonHandlerTests {
    [Fact]
    public void CreatePerson_ValidParameters_ShouldCreatePersonCorrectly() {
        // Arrange
        var personHandler = new PersonHandler();
        string expectedFName = "John";
        string expectedLName = "Doe";
        int expectedAge = 30;
        double expectedHeight = 175;
        double expectedWeight = 70;

        // Act
        Person person =
            personHandler.CreatePerson(expectedFName, expectedLName, expectedAge, expectedHeight, expectedWeight);

        // Assert
        Assert.NotNull(person);
        Assert.Equal(expectedFName, person.FName);
        Assert.Equal(expectedLName, person.LName);
        Assert.Equal(expectedAge, person.Age);
        Assert.Equal(expectedHeight, person.Height);
        Assert.Equal(expectedWeight, person.Weight);
    }

    [Fact]
    public void SetAge_ValidAge_ShouldUpdateAge() {
        // Arrange
        var personHandler = new PersonHandler();
        var person = personHandler.CreatePerson("John", "Doe", 25, 175, 70);
        int newAge = 30;

        // Act
        personHandler.SetAge(person, newAge);

        // Assert
        Assert.Equal(newAge, person.Age);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(0)] // Assuming your validation requires age to be greater than 0
    public void SetAge_InvalidAge_ShouldThrowArgumentException(int invalidAge) {
        // Arrange
        var personHandler = new PersonHandler();
        var person = personHandler.CreatePerson("John", "Doe", 25, 175, 70);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => personHandler.SetAge(person, invalidAge));
    }

    [Fact]
    public void GetterMethods_ShouldReturnCorrectValues() {
        // Arrange
        var personHandler = new PersonHandler();
        var expectedFirstName = "Jane";
        var expectedLastName = "Doe";
        var expectedAge = 28;
        var expectedHeight = 168.5;
        var expectedWeight = 60;
        var person = personHandler.CreatePerson(expectedFirstName, expectedLastName, expectedAge, expectedHeight,
            expectedWeight);

        // Act
        var actualFirstName = personHandler.GetFName(person);
        var actualLastName = personHandler.GetLName(person);
        var actualAge = personHandler.GetAge(person);
        var actualHeight = personHandler.GetHeight(person);
        var actualWeight = personHandler.GetWeight(person);

        // Assert
        Assert.Equal(expectedFirstName, actualFirstName);
        Assert.Equal(expectedLastName, actualLastName);
        Assert.Equal(expectedAge, actualAge);
        Assert.Equal(expectedHeight, actualHeight);
        Assert.Equal(expectedWeight, actualWeight);
    }
}