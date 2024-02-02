namespace prikol
{
    internal class Program
    {
        static int magic() => 10;
        static void Main(string[] args)
        {
            for (int i = 0; i < magic(); i++) 
                Console.WriteLine("Hello, World!");

        }
    }
}
