namespace Constructors_Price_Austin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create and initialize a Game object
            Game game1 = new Game("The Legend of Zelda", "Adventure");

            Console.WriteLine("Title: " + game1.title);
            Console.WriteLine("Genre: " + game1.genre);
            Console.WriteLine();

            // Create a Game object with default values
            Game game2 = new Game();

            Console.WriteLine("Title: " + game2.title);
            Console.WriteLine("Genre: " + game2.genre);
        }
    }
}
