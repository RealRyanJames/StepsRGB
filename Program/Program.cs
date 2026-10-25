using Program;
using Program.Files;

class App
{
    private static readonly Random color = new();
    public static void Main(string[] args)
    {
        if (args.Length < 3)
        {
            Thread.Sleep(3 * Threads);
            Console.Write(SayName.GetNamePerson() + "\n");
            
            Args.Get(PrintName);
            Init();
        }
    }

    public static int Threads => 100 * 10;

    public static string PrintName()
    {
        Console.WriteLine("-------------------------------");
        return Name("Hello User Welcome");
    }

    public static string Name(string name) => name + "\n";

    public static void Init()
    {

        var red = color.Next(0, SayName.R);
        var green = color.Next(0, SayName.G);
        var blue = color.Next(0, SayName.B);

        string Option = "Y | N";
        char optionsReader = Option.First();

        Console.WriteLine("Enter Y | N: ");
        optionsReader = Console.ReadKey().KeyChar;

        string messageHex = $"R: {red}, G: {green}, B: {blue}";
        string hexMessage = $"{Converted.ConvertingR()} {Converted.ConvertingG()} {Converted.ConvertingB()}";

        switch (optionsReader)
        {
            case 'N':

                Console.WriteLine($"R: {red}, G: {green}, B: {blue}");
                Converted.RHex = red;
                Converted.GHex = green;
                Converted.BHex = blue;

                Console.WriteLine("\n");
                Console.WriteLine($"{Converted.ConvertingR()} {Converted.ConvertingG()} {Converted.ConvertingB()}");

                messageHex = $"R: {red}, G: {green}, B: {blue}";
                hexMessage = $"{Converted.ConvertingR()} {Converted.ConvertingG()} {Converted.ConvertingB()}";


                FileWrite.Write(messageHex: messageHex, colorMessage: hexMessage);

                break;

            case 'Y':

                Console.WriteLine($"R: {red}, G: {green}, B: {blue}");
                Converted.RHex = red;
                Converted.GHex = green;
                Converted.BHex = blue;

                Console.WriteLine("\n");
                Console.WriteLine($"{Converted.ConvertingR()} {Converted.ConvertingG()} {Converted.ConvertingB()}");

                FileWrite.Write(messageHex: messageHex, colorMessage: hexMessage);

                break;
        }


        Console.ReadLine();

    }
}