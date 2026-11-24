using System.Security.Cryptography;

public class Creature
{
    public string Name { get; set; } = "";
    public string Species { get; set; } = "";
    public int Energy { get; set; }

    public  void Ferdigheter(string Name, string Species, int Energy)
    {
        System.Console.WriteLine($"{Name} {Species} og har {Energy} energy");
    }

}