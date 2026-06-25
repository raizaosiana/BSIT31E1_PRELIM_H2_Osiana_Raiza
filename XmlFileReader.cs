using ConsoleApp1;
using System.Xml.Linq;

public class XmlFileReader : BaseFileReader
{
    public override string SupportedFormat => "XML";

    protected override void ParseContent(string filePath)
    {
        XDocument xml = XDocument.Load(filePath);

        Console.WriteLine($"Root Element: {xml.Root.Name}");
        Console.WriteLine($"Descendants: {xml.Descendants().Count()}");
    }
}