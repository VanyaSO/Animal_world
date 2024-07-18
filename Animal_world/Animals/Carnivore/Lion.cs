namespace Animal_world;

public class Lion : Carnivore
{
    public Lion(int power)
    {
        Power = power;
    }
    
    public override void Eat(Herbivore animal)
    {
        if (Power > animal.Weight)
        {
            Power += 10;
            animal.Life = false;
        }
        else
            Power -= 10;
    }
}