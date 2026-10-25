namespace Program;

public class Args
{
    public static void Get(Func<string> func) => Console.WriteLine("{0}", func());

}