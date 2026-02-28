namespace Assignment_session_4;

internal class Ticket
{
    private string _movieName = null!;
    private decimal _price;
    private readonly int _ticketId;
    private static int _ticketCounter = 0;

    public string MovieName
    {
        get { return _movieName; }
        set { _movieName = value; }
    }

    public decimal Price
    {
        get { return _price; }
        private set { 
            if (value < 0)
            {
                throw new ArgumentException("Price cannot be negative.");
            }
            _price = value; 
        }
    }

    public decimal PriceAfterTax
    {
        get { return _price * 1.14m; }
    }

    public int TicketId => _ticketId;


    public Ticket(string movieName, decimal price)
    {
        this.MovieName = movieName;
        this.Price = price;
        _ticketId = ++_ticketCounter;
    }

    public static int GetTotalTickets()
    {
        return _ticketCounter;
    }


    public virtual string PrintTicket()
    {
        return $"Ticket ID: {TicketId}, Movie Name: {MovieName}, Price: {Price:C}, Price After Tax: {PriceAfterTax:C}";
    }

    public void SetPrice(decimal price) {
        Price = price;
    }

    public void SetPrice(decimal basePrice, decimal multiplier)
    {
        Price = basePrice * multiplier;
    }
}
