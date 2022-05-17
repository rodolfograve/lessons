namespace Lessons.Polymorphism;

public record Horse() : Animal("Horse")
{
    public override void PrintInWater() => PrintMessage("Paddles in water");
    public override void PrintOnLand() => PrintMessage("Walks on four legs on land");
    public override void PrintWhatItEats() => PrintMessage("Eats grass");
    public override void PrintLifeExpectancy() => PrintMessage("Lives 40 years");
}
