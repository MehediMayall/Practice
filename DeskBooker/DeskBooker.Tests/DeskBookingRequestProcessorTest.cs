using Xunit;
using Moq;
using System;
using System.Collections.Generic;
using DeskBooker.Core;


namespace DeskBooker.Tests;

public class DeskBookingRequestProcessorTest
{
    private readonly DeskBookingRequestProcessor processor;
    private readonly DeskBookingRequest deskBookingRequest;

    private readonly List<Desk> availableDesks;
    private readonly Mock<IDeskBookingRepository> deskBookingRepositoryMock;
    private readonly Mock<IDeskRepository> deskRepositoryMock;

    public DeskBookingRequestProcessorTest()
    {
        deskBookingRequest = new DeskBookingRequest
        {
            Firstname = "Mehedi",
            Lastname = "Hasan",
            Email = "mehedi@gmail.com",
            BookingDate = DateTime.Now
        };

        availableDesks = new List<Desk>{new Desk
        { 
            Id = 1
        }};

        // Mocking Repo

        deskBookingRepositoryMock = new Mock<IDeskBookingRepository>(); 
        deskRepositoryMock = new Mock<IDeskRepository>();


        deskRepositoryMock.Setup(x => x.GetAvailableDesk(deskBookingRequest.BookingDate))
            .Returns(availableDesks);

        processor = new DeskBookingRequestProcessor(
                deskBookingRepositoryMock.Object,
                deskRepositoryMock.Object
                );
    }


    [Fact]
    public void ShouldReturnDeskBookingResultWithRequest()
    {
        // Arrange
        

        // Act
        DeskBookingResult deskBookingResult = processor.BookDesk(deskBookingRequest);

        // Assert
        Assert.Equal(deskBookingRequest.Firstname, deskBookingResult.Firstname);
        Assert.Equal(deskBookingRequest.Lastname, deskBookingResult.Lastname);
        Assert.Equal(deskBookingRequest.Email, deskBookingResult.Email);
        Assert.Equal(deskBookingRequest.BookingDate, deskBookingResult.BookingDate);
    }


    [Fact]
    public void ShouldThrowExceptionIfRequestIsNull()
    {
        // Act
        var exception = Assert.Throws<ArgumentNullException>(() => processor.BookDesk(null));

        Assert.Equal("request", exception.ParamName);
    }

    [Fact]
    public void ShouldSaveDeskBooking()
    {
        // Arrange
        DeskBooking savedDeskBooking = null;

        this.deskBookingRepositoryMock.Setup(x => x.Save(It.IsAny<DeskBooking>()))
            .Callback<DeskBooking>(deskBooking =>{
                savedDeskBooking = deskBooking;
            });

        // Act
        this.processor.BookDesk(this.deskBookingRequest);

        // Assert
        this.deskBookingRepositoryMock.Verify(x => x.Save(It.IsAny<DeskBooking>()));

        Assert.NotNull(savedDeskBooking);

        Assert.Equal(deskBookingRequest.Firstname, savedDeskBooking.Firstname);
        Assert.Equal(deskBookingRequest.Lastname, savedDeskBooking.Lastname);
        Assert.Equal(deskBookingRequest.Email, savedDeskBooking.Email);
        Assert.Equal(deskBookingRequest.BookingDate, savedDeskBooking.BookingDate);
        
    }

    [Fact]
    public void ShouldNotSaveDeskBookingIfDeskUnavailable()
    {
        // Arrange
        this.availableDesks.Clear();

        // Act
        this.processor.BookDesk(this.deskBookingRequest);

        // Assert
        this.deskBookingRepositoryMock.Verify(x => x.Save(It.IsAny<DeskBooking>()), Times.Never);

    }

    [Theory]
    [InlineData(DeskBookingResultCode.SUCCESS, true)]
    [InlineData(DeskBookingResultCode.NO_DESK_AVAILABLE, false)]
    public void ShouldReturnExpectedResultCode(
        DeskBookingResultCode deskBookingResultCode, bool IsDeskAvailable)
    {
        // Arrange
        if (IsDeskAvailable is false) this.availableDesks.Clear();

        // Act
        var result = this.processor.BookDesk(this.deskBookingRequest);

        // Assert
        Assert.Equal(deskBookingResultCode, result.ResultCode);

    }
}