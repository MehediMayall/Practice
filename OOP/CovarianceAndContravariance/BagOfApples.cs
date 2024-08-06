namespace CovarianceAndContravariance;

public class BagOfApples : BagOfFruits
{
    public new Apple Get(int index) =>
        (Apple) base.Get(index);

    public void Add(Apple apple) =>
        base.Add(apple);
}