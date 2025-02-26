internal class World
{
    // metoda constructor implicit
    public World(): this("</>")
    {
        
    }

    public World(string id)
    {
        Id = id;
        Console.WriteLine("World created");
    }

    public string Id { get; }

    public void SayHello()
    {
        Console.WriteLine($"Hello World! from {Id}");
    }
}