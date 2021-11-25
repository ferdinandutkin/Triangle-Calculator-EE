using Core;
using Triangles.Factories;

namespace User;

public class Programm
{

    public static void Main(string[] args)
    {

        LegoShapeFactory shapeFactory = new();

        var (points, color) = InputParser.ParseInput(args);

        Lego lego = new(shapeFactory);

        var output = lego.GetShapeInformation(color, points);

        Console.WriteLine(output);

    }
}