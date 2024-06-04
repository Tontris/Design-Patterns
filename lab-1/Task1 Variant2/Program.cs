class Program
{
    static void Main(string[] args)
    {
        Zoo zoo = new Zoo();
        zoo.Enclosures.Add(new Enclosure { Type = "Lion Enclosure", Size = 100 });
        zoo.Enclosures[0].Animals.Add(new Lion { Name = "Simba" });
        zoo.Workers.Add(new ZooWorker { Name = "John", Role = "Zookeeper" });

        zoo.DisplayInventory();
    }
}