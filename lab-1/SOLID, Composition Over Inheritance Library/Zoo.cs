//SOLID, Composition Over Inheritance Library
public class Zoo
{
    public List<Enclosure> Enclosures { get; set; }
    public List<ZooWorker> Workers { get; set; }

    public Zoo()
    {
        Enclosures = new List<Enclosure>();
        Workers = new List<ZooWorker>();
    }

    public void DisplayInventory()
    {
        foreach (var enclosure in Enclosures)
        {
            Console.WriteLine($"Enclosure Type: {enclosure.Type}, Size: {enclosure.Size}");
            foreach (var animal in enclosure.Animals)
            {
                Console.WriteLine($"Animal Species: {animal.Species}, Name: {animal.Name}");
            }
        }

        foreach (var worker in Workers)
        {
            Console.WriteLine($"Worker Name: {worker.Name}, Role: {worker.Role}");
        }
    }
}