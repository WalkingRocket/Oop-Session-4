using Assignment_session_4;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("========== Cinema Opened ==========");
        var cinema = new Cinema("Cinema hall 1");

        Console.WriteLine("\n========== SettingPrice Test ==========");
        Console.Write($"Setting Price directly: ");
        var InceptionTicket = new StandardTicket("Inception", 120m, "A-5");
        var AvengersVIPTicket = new VIPTicket("Avengers", 200m, true);
        var DuneIMAXTicket = new IMAXTicket("Dune", 180m, false);
        InceptionTicket.SetPrice(150m);
        Console.WriteLine($"{InceptionTicket.Price}");
        Console.Write($"Sitting Price with Multiplier: 100 x 1.5 = ");
        InceptionTicket.SetPrice(100, 1.5m);
        Console.WriteLine($"{InceptionTicket.Price}");

        Console.WriteLine("\n========== All Tickets ==========");
        InceptionTicket.SetPrice(150m);
        cinema.AddTicket(InceptionTicket);
        cinema.AddTicket(AvengersVIPTicket);
        cinema.AddTicket(DuneIMAXTicket);

        cinema.PrintAllTickets();


        Console.WriteLine("\n========== Process Single Ticket ==========");
        Cinema.ProcessTicket(AvengersVIPTicket);

        Console.WriteLine("\n========== Cinema Closed ==========");
        cinema.CloseCinema();
    }
}