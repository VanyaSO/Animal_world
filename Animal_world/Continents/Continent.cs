namespace Animal_world;

public abstract class Continent
{
    public List<Herbivore> listHerbivoreAnimals = new List<Herbivore>();
    public List<Carnivore> listCarnivoreAnimals = new List<Carnivore>();
    protected Random rand = new Random();
    
    public abstract void CreateHerbivoreAnimal();
    public abstract void CreateCarnivoreAnimal();
}