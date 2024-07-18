namespace Animal_world;

public static class AnimalWord
{
    public static void CreateAnimal(Continent continent)
    {
        continent.CreateCarnivoreAnimal();
        continent.CreateHerbivoreAnimal();
    }

    public static void MealsHerbivores(Continent continent)
    {
        foreach (var animal in continent.listHerbivoreAnimals)
            animal.EatGrass();
    }
    
    public static void NutritionCarnivores(Continent continent)
    {
        Herbivore herbivore;
        Carnivore carnivore;
        
        for (int i = 0; i < continent.listCarnivoreAnimals.Count; i++)
        {
            herbivore = continent.listHerbivoreAnimals[i];
            carnivore = continent.listCarnivoreAnimals[i];
            carnivore.Eat(herbivore);
        }
    }
}