class App
{
    private static readonly Random color = new();
    static void Main()
    {
        Console.WriteLine(SayName.GetNamePerson());

        int red = color.Next(0, SayName.R);
        int green = color.Next(0, SayName.G);
        int blue = color.Next(0, SayName.B);
        
        Console.WriteLine($"R: {red}, G: {green}, B: {blue}");
        Console.ReadLine();

    }


}

