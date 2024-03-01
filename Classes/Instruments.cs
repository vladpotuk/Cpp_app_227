using System.Xml.Linq;

public interface IPlayable
{
    void Play();
}

public class Violin : MusicalInstrument, IPlayable
{
    public Violin(string name, string characteristics) : base(name, characteristics)
    {
    }

    public void Play()
    {
        Console.WriteLine($"Playing the {name}...");
    }
}

public class Trombone : MusicalInstrument, IPlayable
{
    public Trombone(string name, string characteristics) : base(name, characteristics)
    {
    }

    public void Play()
    {
        Console.WriteLine($"Playing the {name}...");
    }
}

public class Ukulele : MusicalInstrument, IPlayable
{
    public Ukulele(string name, string characteristics) : base(name, characteristics)
    {
    }

    public void Play()
    {
        Console.WriteLine($"Playing the {name}...");
    }
}

public class Cello : MusicalInstrument, IPlayable
{
    public Cello(string name, string characteristics) : base(name, characteristics)
    {
    }

    public void Play()
    {
        Console.WriteLine($"Playing the {name}...");
    }
}
