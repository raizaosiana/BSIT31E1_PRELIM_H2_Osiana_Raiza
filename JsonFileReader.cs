using ConsoleApp1;
using System.Text.Json;

public class JsonFileReader : BaseFileReader
{
    public override string SupportedFormat => "JSON";

    protected override void ParseContent(string filePath)
    {
        string json = File.ReadAllText(filePath);

        JsonDocument doc = JsonDocument.Parse(json);

        Console.WriteLine($"Root Properties: {doc.RootElement.EnumerateObject().Count()}");
    }
}