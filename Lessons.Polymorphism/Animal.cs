namespace Lessons.Polymorphism;

public abstract record Animal(string Name)
{
    public abstract void PrintInWater();
    public abstract void PrintOnLand();
    public abstract void PrintWhatItEats();
    public abstract void PrintLifeExpectancy();

    protected void PrintMessage(string message)
    {
        var originalColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{Name}: ");
        Console.ForegroundColor = originalColor;
        Console.WriteLine(message);
    }
}
