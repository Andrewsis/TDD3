using TDD3;

class Program
{
    static void Main(string[] args)
    {
        World world = World.GetInstance();

        world.Day = 120; 
        world.Latitude = 50.45;
        world.City = "Kyiv";

        world.PrintInfo();


        World southernWorld = World.GetInstance();
        southernWorld.Day = 3555; 
        southernWorld.Latitude = -33.87;
        southernWorld.City = "Sidney";

        southernWorld.PrintInfo();

        if (world == southernWorld)
        {
            Console.WriteLine("Singleton works");
        }
    }
}
