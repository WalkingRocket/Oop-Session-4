namespace Assignment_session_4;

internal class VIPTicket : Ticket
{
    private bool _hasLoungeAccess;
    private decimal _serviceFee;

    public bool HasLoungeAccess
    {
        get { return _hasLoungeAccess; }
        set { _hasLoungeAccess = value; }
    }

    public decimal ServiceFee
    {
        get { return _serviceFee; }
        set { _serviceFee = value; }
    }

    public VIPTicket(string movieName, decimal price, bool HasLoungeAccess, decimal serviceFee = 50m)
            :base(movieName, price)
    {
        this.HasLoungeAccess = HasLoungeAccess;
        this.ServiceFee = serviceFee;
    }

    public override string PrintTicket()
    {
        return base.PrintTicket() + $", Has Lounge Access: {HasLoungeAccess}, Service Fee: {ServiceFee:C}";
    }

}
