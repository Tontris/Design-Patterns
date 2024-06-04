class Program
{
    static void Main(string[] args)
    {
        Zoo zoo = new Zoo();

        Enclosure lionEnclosure = new Enclosure { Type = "Lion Enclosure", Size = 100 };
        lionEnclosure.Animals.Add(new Lion { Name = "Simba" });
        zoo.Enclosures.Add(lionEnclosure);

        Enclosure elephantEnclosure = new Enclosure { Type = "Elephant Enclosure", Size = 200 };
        elephantEnclosure.Animals.Add(new Elephant { Name = "Dumbo" });
        zoo.Enclosures.Add(elephantEnclosure);

        zoo.Workers.Add(new ZooWorker { Name = "John", Role = "Zookeeper" });

        zoo.DisplayInventory();
    }
}