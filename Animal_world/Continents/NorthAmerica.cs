namespace Animal_world;

public class NorthAmerica : Continent
{
    public NorthAmerica() { }

    public override void CreateHerbivoreAnimal()
    {
        listHerbivoreAnimals.Add(new Bison(rand.Next(90,100)));
    }

    public override void CreateCarnivoreAnimal()
    {
        listCarnivoreAnimals.Add(new Wolf(rand.Next(70,100)));
    }
}