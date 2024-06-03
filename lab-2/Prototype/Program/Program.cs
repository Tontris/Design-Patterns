class Program
{
    static void Main(string[] args)
    {
        Virus grandparent = new Virus("Grandparent", 5, 10.5, "Coronavirus");
        Virus parent1 = new Virus("Parent 1", 3, 8.2, "Influenza");
        Virus parent2 = new Virus("Parent 2", 4, 9.8, "Ebola");

        Virus child1 = new Virus("Child 1", 1, 3.5, "Rhinovirus");
        Virus child2 = new Virus("Child 2", 2, 4.0, "HIV");

        grandparent.AddChild(parent1);
        grandparent.AddChild(parent2);
        parent1.AddChild(child1);
        parent1.AddChild(child2);

        Virus clonedGrandparent = (Virus)grandparent.Clone();

        Console.WriteLine("Original Virus:");
        Console.WriteLine(grandparent);

        Console.WriteLine("\nCloned Virus:");
        Console.WriteLine(clonedGrandparent);

        Console.WriteLine("\nAre original and cloned viruses equal:");
        Console.WriteLine(grandparent == clonedGrandparent);
    }
}
