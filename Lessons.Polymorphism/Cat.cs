namespace Lessons.Polymorphism;

public record Cat() : Animal("Cat")
{
    public override void PrintInWater() => PrintMessage("Cannot swim in water");
    public override void PrintOnLand() => PrintMessage("Walks on four legs on land");
    public override void PrintWhatItEats() => PrintMessage("Eats everything");
    public override void PrintLifeExpectancy() => PrintMessage("Lives 16 years");
}
