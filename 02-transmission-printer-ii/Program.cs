class Program
{
    static void Main()
    {
        PrintTransmission("System ready");
        PrintTransmission("Dock", "Gate unlocked");
        PrintTransmission("Sunday","Closed", "Open on Monday");

        // TODO: Kall også din tredje overload.
    }

    static void PrintTransmission(string message)
    {
        Console.WriteLine($"[UNKNOWN] {message}");
    }

    static void PrintTransmission(string sender, string message)
    {
        Console.WriteLine($"[{sender}] {message}");
    }


    static void PrintTransmission(string sender, string message, string todo)
    {
        Console.WriteLine($"[{sender}] is {message}, {todo}");
    }
    // TODO: Lag tredje overload.
}