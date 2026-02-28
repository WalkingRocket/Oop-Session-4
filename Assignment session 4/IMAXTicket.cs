namespace Assignment_session_4;

internal class IMAXTicket : Ticket
{
    private bool Is3D;

    public bool Is3D1
    {
        get { return Is3D; }
        set { Is3D = value; }
    }

    public IMAXTicket(string movieName, decimal price, bool is3D)
        : base(movieName, price)
    {
        this.Is3D1 = is3D;

        if (is3D)
        {
            SetPrice(Price + 30m);
        }
    }

    public override string PrintTicket()
    {
        return base.PrintTicket() + $", Is 3D: {Is3D1}";
    }
}
