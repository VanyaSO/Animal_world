namespace Animal_world;

public abstract class Carnivore
{
    public int Power { get; set; }

    public abstract void Eat(Herbivore animal);
}