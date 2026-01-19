public class Person
{
    public readonly string Name;
    private bool _is_infinite;
    public int Turns { get; set; }

    internal Person(string name, int turns)
    {
        if (turns <= 0)
        {
            _is_infinite = true;
        }
        Name = name;
        Turns = turns;
    }

    public override string ToString()
    {
        return Turns <= 0 ? $"({Name}:Forever)" : $"({Name}:{Turns})";
    }

    public bool IsInfinite()
    {

        return _is_infinite;


    }
}