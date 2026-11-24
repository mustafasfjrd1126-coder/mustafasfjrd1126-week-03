class Program
{
    static void Main()
    {
        PrintTransmission("Calibration complete");
        PrintTransmission("Relay-7", "Signal acquired");
    }
    static void PrintTransmission(string message)
    {
        // TODO
        Console.WriteLine($"Unknown {message}"); 
    }

    static void PrintTransmission(string sender, string message)
    {
        // TODO
       Console.WriteLine($"Sender: {sender} and his message: {message}"); 
    }
}