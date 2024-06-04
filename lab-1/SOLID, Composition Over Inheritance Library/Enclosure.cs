//SOLID, Composition Over Inheritance Library
public class Enclosure
{
    public string Type { get; set; }
    public int Size { get; set; }
    public List<Animal> Animals { get; set; }

    public Enclosure()
    {
        Animals = new List<Animal>();
    }
}