namespace Lessons.Polymorphism;

public record Shark() : Animal("Shark")
{
    public override void PrintInWater() => PrintMessage("Swims in water");
    public override void PrintOnLand() => PrintMessage("Cannot walk on land");
    public override void PrintWhatItEats() => PrintMessage("Eats fish");
    public override void PrintLifeExpectancy() => PrintMessage("Lives 60 years");
}
