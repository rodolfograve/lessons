namespace Lessons.Polymorphism;

public record Dog() : Animal("Dog")
{
    public override void PrintInWater() => PrintMessage("Paddles in water");
    public override void PrintOnLand() => PrintMessage("Walks on four legs on land");
    public override void PrintWhatItEats() => PrintMessage("Eats everything");
    public override void PrintLifeExpectancy() => PrintMessage("Lives 16 years");
}
