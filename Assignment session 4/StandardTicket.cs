namespace Assignment_session_4;

internal class StandardTicket: Ticket
{
    private string _seatNumber = null!;

    public string SeatNumber
    {
        get { return _seatNumber; }
        set { _seatNumber = value; }
    }

    public StandardTicket(string movieName, decimal price, string seatNumber)
        :base(movieName, price)
    {
        this.SeatNumber = seatNumber;
    }

    public override string PrintTicket()
    {
        return base.PrintTicket() + $", Seat Number: {SeatNumber}";
    }
}
