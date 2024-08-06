namespace CovarianceAndContravariance;

public interface IBag<out T>
{
    T Get(int index);
}