namespace Lessons.Polymorphism;

public record EvolvedPenguin() : Penguin()
{
    public override void PrintWhatItEats()
    {
        base.PrintWhatItEats();
        Console.WriteLine("Penguin: we also eat easier-to-find stuff");
    }
}
