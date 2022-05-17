namespace Lessons.Polymorphism;

public record Penguin() : Animal("Penguin")
{
    public override void PrintInWater() => PrintMessage("Swims in water");
    public override void PrintOnLand() => PrintMessage("Paddles on land");
    public override void PrintWhatItEats() => PrintMessage("Eats fish");
    public override void PrintLifeExpectancy() => PrintMessage("Lives 40 years");
}
