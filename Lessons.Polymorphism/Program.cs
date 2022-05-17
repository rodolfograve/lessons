// See https://aka.ms/new-console-template for more information
using Lessons.Polymorphism;

var animals = new List<Animal>() { new EvolvedPenguin(), new Dog(), new Cat(), new Shark(), new Horse() };


PrintInWater();
PrintOnLand();
PrintWhatItEats();
MoveAllAnimals();

Console.ReadLine();

void MoveAnimal(Animal animal)
{
    var transportationAdapter = new AnimalTransportationAdapter(animal);
    Move(transportationAdapter);
}

void Move(Transportation transportation)
{
    transportation.Move();
}

void PrintInWater()
{
    foreach (var animal in animals)
    {
        animal.PrintInWater();
    }

    //new Penguin().PrintInWater();
    //new Dog().PrintInWater();
    //new Cat().PrintInWater();
    //foreach (var animal in animals)
    //{
    //    switch (animal)
    //    {
    //        case "Penguin": Console.WriteLine("Penguin:\tSwims in water"); break;
    //        case "Dog": Console.WriteLine("Dog:\tPaddles in water"); break;
    //        case "Cat": Console.WriteLine("Cat:\tCannot swim in water"); break;
    //        case "Shark": Console.WriteLine("Shark:\tSwims in water"); break;
    //    }
    //}
}

void PrintOnLand()
{
    foreach (var animal in animals)
    {
        animal.PrintOnLand();
    }

    //new Penguin().PrintOnLand();
    //new Dog().PrintOnLand();
    //new Cat().PrintOnLand();
    //foreach (var animal in animals)
    //{
    //    switch (animal)
    //    {
    //        case "Penguin": Console.WriteLine("Penguin:\tPaddles on land"); break;
    //        case "Dog": Console.WriteLine("Dog:\tWalks on four legs on land"); break;
    //        case "Cat": Console.WriteLine("Cat:\tWalks on four legs on land"); break;
    //        case "Shark": Console.WriteLine("Shark:\tCannot walk on land"); break;
    //    }
    //}
}

void PrintWhatItEats()
{
    foreach (var animal in animals)
    {
        animal.PrintWhatItEats();
    }

    //new Penguin().PrintWhatItEats();
    //new Dog().PrintWhatItEats();
    //new Cat().PrintWhatItEats();
    //foreach (var animal in animals)
    //{
    //    switch (animal)
    //    {
    //        case "Penguin": Console.WriteLine("Penguin:Eats fish"); break;
    //        case "Dog": Console.WriteLine("Dog:Eats everything"); break;
    //        case "Cat": Console.WriteLine("Cat:Eats everything"); break;
    //        case "Shark": Console.WriteLine("Shark:\tEats fish"); break;
    //    }
    //}
}

void MoveAllAnimals()
{
    foreach (var animal in animals)
    {
        MoveAnimal(animal);
    }
}