using FluentAssertions;
using System.Reflection;
using Xunit;


namespace HelloWorld.tests;

public class ProgramTests
{
    [Fact]
    public void Main_input_2004_output_True()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        var program = Assembly.Load(nameof(HelloWorld));
        program.EntryPoint?.Invoke(null, new[] { new string[] { "2004" } });

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("yay");
    }

    [Fact]
    public void Main_input_2003_output_False()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        var program = Assembly.Load(nameof(HelloWorld));
        program.EntryPoint?.Invoke(null, new[] { new string[] { "2003" } });

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay");
    }

    [Fact]
    public void Main_input_2000_output_True()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        var program = Assembly.Load(nameof(HelloWorld));
        program.EntryPoint?.Invoke(null, new[] { new string[] { "2000" } });

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("yay");
    }
    [Fact]
    public void Main_input_1900_output_False()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        var program = Assembly.Load(nameof(HelloWorld));
        program.EntryPoint?.Invoke(null, new[] { new string[] { "1900" } });

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay");
    }
}