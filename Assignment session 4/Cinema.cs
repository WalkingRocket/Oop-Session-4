namespace Assignment_session_4;

internal class Cinema
{
    private string _name = null!;
    private readonly Projector projector;

    private Ticket[] _tickets = new Ticket[20];

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Cinema(string name)
    {
        this.Name = name;
        projector = new Projector();
        projector.TurnOn();
    }

    public void AddTicket(Ticket t)
    {
        for (int i = 0; i <  _tickets.Length; i++)
        {
            if (_tickets[i] == null)
            {
                _tickets[i] = t;
                return;
            }
        }
     throw new InvalidOperationException("No more seats available.");
    }

    public void PrintAllTickets()
    {
        foreach (var t in _tickets)
        {
            if (t != null)
            {
                Console.WriteLine(t.PrintTicket());
            }
        }
    }

    public static void ProcessTicket(Ticket t)
    {
        Console.WriteLine(t.PrintTicket());
    }

    public void OpenCinema()
    {
        projector.TurnOn();
        Console.WriteLine("Movie is starting...");
    }

    public void CloseCinema()
    {
        projector.TurnOff();
        Console.WriteLine("Movie has ended.");
    }
}
