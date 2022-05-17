namespace Lessons.Polymorphism;

public record Bus() : Transportation()
{
    public override void Move()
    {
        Console.WriteLine("Filling the gas tank");
        Console.WriteLine("Now I'm moving");
    }
}
