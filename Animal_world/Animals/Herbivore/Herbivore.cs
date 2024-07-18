namespace Animal_world;

public abstract class Herbivore
{
    public int Weight { get; set; }
    public bool Life { get; set; }

    public abstract void EatGrass();
}