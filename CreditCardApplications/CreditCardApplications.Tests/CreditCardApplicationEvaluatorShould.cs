using CreditCardApplications;
using Moq;

namespace CreditCardApplications.Tests;

public class CreditCardApplicationEvaluatorShould
{
    private readonly CreditCardApplicationEvaluator sut;
    private CreditCardApplication application;

    public CreditCardApplicationEvaluatorShould()
    {
        var validator = new Mock<IFrequentFlyerNumberValidator>();
        validator.Setup(x => x.IsValid("ABC")).Returns(true);

        this.sut = new CreditCardApplicationEvaluator(validator.Object);
        
    }


    [Fact]
    public void AcceptHighIncomeApplications()
    {
        var expect = CreditCardApplicationDecision.AUTO_ACCEPTED;

        this.application = new CreditCardApplication{
            GrossAnnualIncome = 110_000M,
            FrequentFlyerNumber = "test"
        };

        var result = this.sut.evaluate(this.application);

        Assert.Equal(expect, result);
    }

    [Fact]
    public void DeclineUnderAgeApplication()
    {
        var expect = CreditCardApplicationDecision.REFERRED_TO_HUMAN;

        this.application = new CreditCardApplication{
            GrossAnnualIncome = 30_000M,
            Age = 18,
            FrequentFlyerNumber = "ABC"
        };

        var result = this.sut.evaluate(this.application);

        Assert.Equal(expect, result);
    }

}