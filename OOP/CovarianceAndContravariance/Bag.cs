namespace CovarianceAndContravariance;

public class Bag<T> : IBag<T>
{
    private List<T> fruits = new List<T>();

    public T Get(int index) => fruits[index];

    public void Add(T fruit) =>
        fruits.Add(fruit);

}