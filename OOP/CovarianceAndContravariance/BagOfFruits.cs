namespace CovarianceAndContravariance;

public class BagOfFruits
{
    private List<Fruit> fruits = new List<Fruit>();

    public virtual Fruit Get(int index) =>
        fruits[index];

    public virtual void Add(Fruit fruit) =>
        fruits.Add(fruit); 
}
