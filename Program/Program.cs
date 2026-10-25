using Program;

class App
{
    private static readonly Random color = new();
    public static void Main(string[] args)
    {
        if (args.Length.Equals(0))
        {

            Init();
        }
    }

    public static void Init()
    {

        Console.WriteLine(SayName.GetNamePerson());
        var red = color.Next(0, SayName.R);
        var green = color.Next(0, SayName.G);
        var blue = color.Next(0, SayName.B);

        Console.WriteLine($"R: {red}, G: {green}, B: {blue}");
        Converted.RHex = red;
        Converted.GHex = green;
        Converted.BHex = blue;

        Console.WriteLine($"{Converted.ConvertingR()} {Converted.ConvertingG()} {Converted.ConvertingB()}");

        Console.ReadLine();

    }
}