namespace Animal_world;

public class Wolf : Carnivore
{
    public Wolf(int power)
    {
        Power = power;
    }
    
    public override void Eat(Herbivore animal)
    {
        if (Power > animal.Weight)
            animal.Life = false;
        else
            Power -= 10;
    }
}