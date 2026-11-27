List<Artifact> artifacts = new List<Artifact>();

Artifact a1 = new Artifact("SNO", "OSLO", 1);
artifacts.Add(a1);
Artifact a2 = new Artifact("REIN", "TRONDHEIM", 2);
artifacts.Add(a2);
Artifact A3 = new Artifact("WIND", "STAVANGER", 3);
artifacts.Add(A3);


// TODO: Opprett minst fire Artifact-objekter og legg dem i listen.
// TODO: Skriv Count og alle objektene.
// TODO: Legg til ett ekstra objekt og skriv Count igjen.

System.Console.WriteLine($"Artifact count is :{artifacts.Count()}");

foreach (var item in artifacts)
{
    System.Console.WriteLine($"{item.Name}, {item.Origin}, {item.Risk}");
}

Artifact a4 = new Artifact("SUN", "TONSBERG", 2);
artifacts.Add(a4);
System.Console.WriteLine($"Added 1 more artifact and artifact count is : {artifacts.Count()} now");


