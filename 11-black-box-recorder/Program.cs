using System.Threading.Tasks.Dataflow;

string path = "blackbox.txt";

// TODO: Hvis filen ikke finnes, skriv eksempeldata.
// TODO: Les så alle linjene og skriv dem ut.

if (!File.Exists(path))
{
    List<string> eksempelData = new List<string>{"blackbox testing 1","testing 2","last testing"};
    File.WriteAllLines(path,eksempelData);
}

foreach (var item in File.ReadAllLines(path))
{
    System.Console.WriteLine(item);

}
