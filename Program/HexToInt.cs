namespace Program;

public class Converted
{
    public static int RHex = 0;
    public static int GHex = 0;
    public static int BHex = 0;

    public static string ConvertingR() => RHex.ToString("X4");

    public static string ConvertingG() => GHex.ToString("X4");

    public static string ConvertingB() => BHex.ToString("X4");
}