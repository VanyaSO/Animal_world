namespace Animal_world;

class Program
{
    static void Main(string[] args)
    {
        Africa africa = new Africa();

        for (int i = 0; i < 5; i++)
            AnimalWord.CreateAnimal(africa);
        
        Console.WriteLine("HerbivoreAnimals before nutrition carnivores");
        foreach (var animal in africa.listHerbivoreAnimals)
        {
            Console.Write(animal.Weight);
            Console.Write(animal.Life);
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        
        AnimalWord.NutritionCarnivores(africa);
        Console.WriteLine("HerbivoreAnimals after nutrition carnivores");
        foreach (var animal in africa.listHerbivoreAnimals)
        {
            Console.Write(animal.Weight);
            Console.Write(animal.Life);
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        
        
        Console.WriteLine("CarnivoreAnimals before eat");
        foreach (var animal in africa.listCarnivoreAnimals)
        {
            Console.Write(animal.Power);
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        
        AnimalWord.NutritionCarnivores(africa);
        
        Console.WriteLine("CarnivoreAnimals after eat");
        foreach (var animal in africa.listCarnivoreAnimals)
        {
            Console.Write(animal.Power);
            Console.WriteLine();
        }
    }
}