using CreditCardApplications;
using Moq;

namespace CreditCardApplications.Tests;

public class CreditCardApplicationEvaluatorShould
{
    private CreditCardApplicationEvaluator sut;
    private CreditCardApplication application;

    public CreditCardApplicationEvaluatorShould()
    {

        this.application = new CreditCardApplication{
            GrossAnnualIncome = 110_000M,
            FrequentFlyerNumber = "XYZ"
        };

        var validator = new Mock<IFrequentFlyerNumberValidator>();
        validator.Setup(x => x.IsValid("ABC")).Returns(true);
        // validator.Setup(x => x.LicenseKey).Returns("EXPIRED");

        this.sut = new CreditCardApplicationEvaluator(validator.Object);
        
    }


    [Fact]
    public void AcceptHighIncomeApplications()
    {
        var expect = CreditCardApplicationDecision.AUTO_ACCEPTED;

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

    [Fact]
    public void ReferToHumanIfLicenseKeyExpired()
    {
        // Arrange
        var expect = CreditCardApplicationDecision.REFERRED_TO_HUMAN;


        var validator = new Mock<IFrequentFlyerNumberValidator>();
        // validator.Setup(x => x.LicenseKey).Returns("EXPIRED");
        validator.Setup(x => x.LicenseKey).Returns(GetLicenseKeyExpiryString);

        this.sut = new CreditCardApplicationEvaluator(validator.Object);
        this.application.GrossAnnualIncome = 30_000M;

        // Act
        var result = this.sut.evaluate(this.application);

        // Assert
        Assert.Equal(expect, result);
    }

    public string GetLicenseKeyExpiryString() => "EXPIRED";


}