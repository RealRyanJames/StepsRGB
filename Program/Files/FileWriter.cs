namespace Program.Files
{
    public class FileWrite
    {
        public static void Write(string messageHex, string colorMessage)
        {

            using (TextWriter write = new StreamWriter("main.txt"))
            {
                write.WriteLine($"{messageHex}");
                write.WriteLine($"{colorMessage}");

            }
        }
    }
}