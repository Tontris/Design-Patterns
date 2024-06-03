using System;
using System.Collections.Generic;

public class Character
{
    public double Height { get; set; }
    public string Build { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    public string Clothing { get; set; }
    public List<string> Inventory { get; set; }
    public List<string> GoodDeeds { get; set; }
    public List<string> EvilDeeds { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Height: {Height}");
        Console.WriteLine($"Build: {Build}");
        Console.WriteLine($"Hair Color: {HairColor}");
        Console.WriteLine($"Eye Color: {EyeColor}");
        Console.WriteLine($"Clothing: {Clothing}");
        Console.WriteLine("Inventory:");
        foreach (var item in Inventory)
        {
            Console.WriteLine($"- {item}");
        }
        if (GoodDeeds != null)
        {
            Console.WriteLine("Good Deeds:");
            foreach (var deed in GoodDeeds)
            {
                Console.WriteLine($"- {deed}");
            }
        }
        if (EvilDeeds != null)
        {
            Console.WriteLine("Evil Deeds:");
            foreach (var deed in EvilDeeds)
            {
                Console.WriteLine($"- {deed}");
            }
        }
    }
}