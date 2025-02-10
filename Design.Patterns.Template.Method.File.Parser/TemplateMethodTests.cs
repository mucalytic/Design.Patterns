using Design.Patterns.Template.Method.File.Parser.Interfaces;
using Design.Patterns.Template.Method.File.Parser.Providers;
using Design.Patterns.Template.Method.File.Parser.Parsers;
using System.Globalization;
using Xunit.Abstractions;
using FluentAssertions;
using NSubstitute;

namespace Design.Patterns.Template.Method.File.Parser;

public class TemplateMethodTests
{
    private const string FilePath = @"C:\Git\Design.Patterns\Design.Patterns.Template.Method.File.Parser\Files";

    private readonly IDateTimeProvider _dateTimeProvider = Substitute.For<IDateTimeProvider>();
    private readonly ITestOutputHelper _helper = Substitute.For<ITestOutputHelper>();
    
    [Fact]
    public void CsvParser_ShouldReturnExpectedResult()
    {
        // arrange
        var dateTime = new DateTime(1911, 03, 13);
        const string filePath = @$"{FilePath}\config.csv";
        
        var fileSystemProvider = new FileSystemProvider();
        var fileParser = new CsvParser(_helper, _dateTimeProvider, fileSystemProvider);
        
        _dateTimeProvider.UtcNow.Returns(dateTime);
        
        // act
        var data = fileParser.ParseFile(filePath);

        // assert
        _helper.Received(1).WriteLine("00:00:00: Validating the file");
        _helper.Received(1).WriteLine("00:00:00: Loading the file");
        _helper.Received(1).WriteLine("00:00:00: Parsing the content");
        _helper.Received(1).WriteLine("00:00:00: Enriching the data");
        _helper.Received(1).WriteLine("00:00:00: Validating the data");

        data.Should().NotBeEmpty();
        data["Timeout"].Should().Be("30");
        data["MaxRetries"].Should().Be("3");
        data["DataType"].Should().Be("CSV");
        data["ApiKey"].Should().Be("apiKey");
        data["DatabaseConnection"].Should().Be("Server=server;Database=database");
        data["ParsedAt"].Should().Be(dateTime.ToString(CultureInfo.InvariantCulture));
    }
    
    [Fact]
    public void JsonParser_ShouldReturnExpectedResult()
    {
        // arrange
        var dateTime = new DateTime(1911, 03, 13);
        const string filePath = @$"{FilePath}\config.json";
        
        var jsonSerialiser = new JsonSerialiser();
        var fileSystemProvider = new FileSystemProvider();
        var fileParser = new JsonParser(_helper, jsonSerialiser, _dateTimeProvider, fileSystemProvider);

        _dateTimeProvider.UtcNow.Returns(dateTime);

        // act
        var data = fileParser.ParseFile(filePath);

        // assert
        _helper.Received(1).WriteLine("00:00:00: Validating the file");
        _helper.Received(1).WriteLine("00:00:00: Loading the file");
        _helper.Received(1).WriteLine("00:00:00: Parsing the content");
        _helper.Received(1).WriteLine("00:00:00: Enriching the data");
        _helper.Received(1).WriteLine("00:00:00: Validating the data");

        data.Should().NotBeEmpty();
        data["Timeout"].Should().Be("30");
        data["MaxRetries"].Should().Be("3");
        data["ApiKey"].Should().Be("apiKey");
        data["DatabaseConnection"].Should().Be("Server=server;Database=database");
        data["ParsedAt"].Should().Be(dateTime.ToString(CultureInfo.InvariantCulture));
    }
}
