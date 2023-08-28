namespace CreditCardApplications;

public interface IFrequentFlyerNumberValidator
{
    bool IsValid(string FrequentFlyerNumber);
    void IsValid(string FrequentFlyerNumber, out bool IsValid);
}