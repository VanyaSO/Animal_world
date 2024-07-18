namespace Animal_world;

public class Bison : Herbivore
{
    public Bison(int weight)
    {
        Weight = weight;
    }
    
    public override void EatGrass()
    {
        if (!Life)
            throw new Exception("The animal is not alive");
        
        Weight += 10;
    }
}