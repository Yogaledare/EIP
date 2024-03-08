namespace EIP.Tests;

using Xunit;
using _3._2_Polymorphism;

public class UserErrorTests {
    [Fact]
    public void NumericInputError_UEMessage_ShouldReturnExpectedMessage() {
        var error = new NumericInputError();
        var message = error.UEMessage();
        Assert.Equal("You tried to use a numeric input in a text only field. This fired an error!", message);
    }

    [Fact]
    public void TextInputError_UEMessage_ShouldReturnExpectedMessage() {
        var error = new TextInputError();
        var message = error.UEMessage();
        Assert.Equal("You tried to use a text input in a numeric only field. This fired an error!", message);
    }

    [Fact]
    public void SnakeError_UEMessage_ShouldReturnExpectedMessage() {
        var error = new SnakeError();
        var message = error.UEMessage();
        Assert.Equal("You tried to pet a snake. This fired an error!", message);
    }

    [Fact]
    public void DrivingError_UEMessage_ShouldReturnExpectedMessage() {
        var error = new DrivingError();
        var message = error.UEMessage();
        Assert.Equal("You tried to put in the reverse while driving on the highway. This fired an error!", message);
    }

    [Fact]
    public void ClothesOrderError_UEMessage_ShouldReturnExpectedMessage() {
        var error = new ClothesOrderError();
        var message = error.UEMessage();
        Assert.Equal("You tried to put on your shoes before you put on your pants. This fired an error!", message);
    }
    
    [Fact]
    public void UserErrors_UEMessage_ShouldReturnSpecificMessages() {
        // Arrange
        var errors = new List<UserError> {
            new NumericInputError(),
            new TextInputError(),
            new SnakeError(),
            new DrivingError(),
            new ClothesOrderError(),
        };

        var expectedMessages = new List<string> {
            "You tried to use a numeric input in a text only field. This fired an error!",
            "You tried to use a text input in a numeric only field. This fired an error!",
            "You tried to pet a snake. This fired an error!",
            "You tried to put in the reverse while driving on the highway. This fired an error!",
            "You tried to put on your shoes before you put on your pants. This fired an error!",
        };

        // Act & Assert
        for (int i = 0; i < errors.Count; i++) {
            var message = errors[i].UEMessage();
            Assert.Equal(expectedMessages[i], message);
        }
    }
    
}
