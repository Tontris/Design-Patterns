using System;
using System.Collections.Generic;

public class Virus : ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public string Species { get; set; }
    public List<Virus> Children { get; set; } = new List<Virus>();

    public Virus(string name, int age, double weight, string species)
    {
        Name = name;
        Age = age;
        Weight = weight;
        Species = species;
    }

    public void AddChild(Virus child)
    {
        Children.Add(child);
    }

    public object Clone()
    {
        Virus clonedVirus = new Virus(Name, Age, Weight, Species);

        foreach (var child in Children)
        {
            clonedVirus.AddChild((Virus)child.Clone());
        }

        return clonedVirus;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Species: {Species}";
    }
}