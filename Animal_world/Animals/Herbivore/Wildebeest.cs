namespace Animal_world;

public class Wildebeest : Herbivore
{
    public Wildebeest(int power)
    {
        Weight = power;
        Life = true;
    }

    public override void EatGrass()
    {
        if (!Life)
            throw new Exception("The animal is not alive");
        
        Weight += 10;
    }
}