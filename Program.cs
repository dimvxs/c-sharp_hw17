// See https://aka.ms/new-console-template for more information
using hw1;
using static System.Console;

class Program
{
    static void Main()
    {

        ITransport[] transports =
        {
            new Airship(),
            new Auto(),
        };

        // Обработка каждого транспортного средства
        foreach (var transport in transports)
        {
            HandleTransport(transport);
            WriteLine(GetTransportInfo(transport));
        }
    }

        public static void HandleTransport(ITransport transport)
    {
        // Используем pattern matching для обработки транспортных средств
        if (transport is Airship airship)
        {
            airship.Start();
            airship.Go();
            airship.Info();
        }
        else if (transport is Auto auto)
        {
            WriteLine($"Auto: {auto.Name} is starting.");
        }
        else
        {
            WriteLine("Unknown transport type.");
        }
    }

    public static string GetTransportInfo(ITransport transport) =>
        transport switch
        {
            Airship airship => $"Airship: {airship.Name}, Tank Volume: {airship.TankVolume}",
            Auto auto => $"Auto: {auto.Name}, Tank Volume: {auto.TankVolume}",
            _ => "Unknown transport type."
        };
}