namespace CreditCardApplications;

public class CreditCardApplicationEvaluator
{
    public const int AutoReferralMaxAge = 20;
    public const decimal HighIncomeThreshold = 100_000M;
    public const decimal LowIncomeThreshold = 20_000M;

    public IFrequentFlyerNumberValidator validator { get; init; }

    public CreditCardApplicationEvaluator(IFrequentFlyerNumberValidator validator)
    {
        this.validator = validator;
    }

    public CreditCardApplicationDecision evaluate(CreditCardApplication application)
    {        

        if(application.GrossAnnualIncome >= HighIncomeThreshold)
            return CreditCardApplicationDecision.AUTO_ACCEPTED;

        var isValidFrequentFlyerNumber = this.validator.IsValid(application.FrequentFlyerNumber);

        if (!isValidFrequentFlyerNumber) return CreditCardApplicationDecision.REFERRED_TO_HUMAN;

        if(application.GrossAnnualIncome < LowIncomeThreshold) 
            return CreditCardApplicationDecision.AUTO_DECLINED;

        if(application.GrossAnnualIncome >= LowIncomeThreshold && application.Age < AutoReferralMaxAge )
            return CreditCardApplicationDecision.REFERRED_TO_HUMAN;
        
        return CreditCardApplicationDecision.REFERRED_TO_HUMAN;
        
    }
}