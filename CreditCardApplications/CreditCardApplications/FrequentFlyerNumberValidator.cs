namespace CreditCardApplications;

public class FrequentFlyerNumberValidatorService: IFrequentFlyerNumberValidator
{

    public bool IsValid(string FrequentFlyerNumber)
    {
        throw new NotImplementedException("Simulate this real dependency being hard to use");
    }

    public void IsValid(string FrequentFlyerNumber, out bool IsValid)
    {
        throw new NotImplementedException("Simulate this real dependency being hard to use");
    }

    public string LicenseKey
    {
        get{ throw new NotImplementedException("EXPIRED"); }
    }

}