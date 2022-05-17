namespace Lessons.Polymorphism;

public record AnimalTransportationAdapter(Animal Adaptee) : Transportation()
{
    public override void Move()
    {
        Console.WriteLine("Need to eat first!");
        Adaptee.PrintWhatItEats();
        Console.WriteLine("Now I'm moving!");
    }
}
