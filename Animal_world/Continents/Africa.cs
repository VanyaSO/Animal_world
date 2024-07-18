namespace Animal_world;

public class Africa : Continent
{
    public Africa() { }

    public override void CreateHerbivoreAnimal()
    {
        listHerbivoreAnimals.Add(new Wildebeest(rand.Next(90,100)));
    }

    public override void CreateCarnivoreAnimal()
    {
        listCarnivoreAnimals.Add(new Lion(rand.Next(70,100)));
    }
}