using ConsoleApp1;

public class CsvFileReader : BaseFileReader
{
    public override string SupportedFormat => "CSV";

    protected override void ParseContent(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);

        int rows = lines.Length;
        int columns = lines[0].Split(',').Length;

        Console.WriteLine($"Rows: {rows}");
        Console.WriteLine($"Columns: {columns}");
    }
}