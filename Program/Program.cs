using Program;

class App
{
    private static readonly Random color = new();
    public static void Main(string[] args)
    {
        if (args.Length < 3)
        {
            Console.Write(SayName.GetNamePerson() + "\n");
            Args.Get(printName);

            Init();

        }
    }

    public static string printName()
    {
        Console.WriteLine("-------------------------------");
        return Name("Hello User Welcome");
    }

    public static string Name(string name)
    {
        return name + "\n";
    }

    public static void Init()
    {

        var red = color.Next(0, SayName.R);
        var green = color.Next(0, SayName.G);
        var blue = color.Next(0, SayName.B);

        Console.WriteLine($"R: {red}, G: {green}, B: {blue}");
        Converted.RHex = red;
        Converted.GHex = green;
        Converted.BHex = blue;

        Console.WriteLine("\n");
        Console.WriteLine($"{Converted.ConvertingR()} {Converted.ConvertingG()} {Converted.ConvertingB()}");


        Console.ReadLine();

    }
}