public class DiceRoll
{
    private readonly Random _rnd;
    public int _die { get; private set; }  = 0;

    public DiceRoll()
    {
        _rnd = new Random();
        _die = _rnd.Next(1, 7);
    }
}


