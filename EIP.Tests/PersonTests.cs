namespace EIP.Tests;

using Xunit;
using _3._1_Encapsulation;

public class PersonTests {
    [Fact]
    public void Construct_ValidPerson_ShouldNotThrow() {
        // Arrange & Act
        var exception = Record.Exception(() => new Person("Jane", "Doe") {
            Age = 30,
            Height = 175,
            Weight = 70
        });

        // Assert
        Assert.Null(exception);
    }


    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    public void SetAge_InvalidAge_ShouldThrowArgumentException(int invalidAge) {
        // Arrange
        var person = new Person("Test", "User");

        // Act & Assert
        Assert.Throws<ArgumentException>(() => person.Age = invalidAge);
    }


    [Theory]
    [InlineData("A")]
    [InlineData("ThisNameIsWayTooLong")]
    [InlineData(null)]
    [InlineData(" ")]
    public void SetFName_InvalidNames_ShouldThrowArgumentException(string invalidFName) {
        // Arrange
        var person = new Person("Test", "User");
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => person.FName = invalidFName);
    }


    [Theory]
    [InlineData("A")]
    [InlineData("ThisNameIsWayTooLongForLNameValidation")]
    [InlineData(null)]
    [InlineData(" ")]
    public void SetLName_InvalidNames_ShouldThrowArgumentException(string invalidLName) {
        // Arrange
        var person = new Person("Test", "User");

        // Act & Assert
        Assert.Throws<ArgumentException>(() => person.LName = invalidLName);
    }
}