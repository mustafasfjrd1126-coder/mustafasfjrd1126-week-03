public class ArtifactCatalog
{
    private List<Artifact> artifacts = new List<Artifact>();

    public void Add(Artifact artifact)
    {
        // TODO
        artifacts.Add(artifact);
    }

    public void PrintAll()
    {
        // TODO
        foreach (var item in artifacts)
        {
            System.Console.WriteLine($"Artifact Name :{item.Name} Artifact Origin: {item.Origin}");
        }
    }

    public Artifact? FindByName(string name)
    {
        // TODO: Finn manuelt med løkke.
        foreach (var item in artifacts)
        {
            if (item.Name == name)
            {
                return item;
            }
        }

        return null;
    }
}
