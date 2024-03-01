class Program
{
    static void Main()
    {
        Violin violin = new Violin("Violin", "String instrument");
        Trombone trombone = new Trombone("Trombone", "Brass instrument");
        Ukulele ukulele = new Ukulele("Ukulele", "String instrument");
        Cello cello = new Cello("Cello", "String instrument");

        violin.Show();
        violin.Play();
        violin.Desc();
        violin.History();

        Console.WriteLine();

        trombone.Show();
        trombone.Play();
        trombone.Desc();
        trombone.History();

        Console.WriteLine();

        ukulele.Show();
        ukulele.Play();
        ukulele.Desc();
        ukulele.History();

        Console.WriteLine();

        cello.Show();
        cello.Play();
        cello.Desc();
        cello.History();
    }
}

