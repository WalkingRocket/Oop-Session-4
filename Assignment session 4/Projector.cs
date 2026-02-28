namespace Assignment_session_4;

internal class Projector
{
    private bool _isOn;

    public bool IsOn
    {
        get { return _isOn; }
        set { _isOn = value; }
    }

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine("Projector is now ON.");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine("Projector is now OFF.");
    }
}

