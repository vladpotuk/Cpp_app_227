using System;

public class MusicalInstrument
{
    protected string name;
    protected string characteristics;
    protected DateTime creationDate;

    public MusicalInstrument(string name, string characteristics)
    {
        this.name = name;
        this.characteristics = characteristics;
        this.creationDate = DateTime.Now;
    }

    public void Sound()
    {
        Console.WriteLine($"Playing the sound of {name}...");
    }

    public void Show()
    {
        Console.WriteLine($"Musical instrument: {name}");
    }

    public void Desc()
    {
        Console.WriteLine($"Characteristics of {name}: {characteristics}");
    }

    public void History()
    {
        Console.WriteLine($"Instrument {name} was created on {creationDate}");
    }
}
