﻿using Xunit;

namespace Logger.Tests;

public class FullNameTests
{
    [Fact]
    public void FullName_WithMiddleName_ShouldReturnCorrectFormat()
    {
        // Arrange
        var fullName = new FullName("Chris", "Cornell", "J");

        // Act
        var result = fullName.ToString();

        // Assert
        Assert.Equal("Chris J Cornell", result);
    }

    [Fact]
    public void FullName_WithoutMiddleName_ShouldReturnCorrectFormat()
    {
        // Arrange
        var fullName = new FullName("Chris", "Cornell", " ");

        // Act
        var result = fullName.ToString();

        // Assert
        Assert.Equal("Chris Cornell", result);

    }



    [Fact]
    public void FullName_WithBlankMiddleName_ShouldSetMiddleNameToNull()
    {
        // Arrange
        var fullName = new FullName("Chris", "Cornell", " ");

        // Act & Assert
        Assert.Null(fullName.MiddleName); 
    }
}
