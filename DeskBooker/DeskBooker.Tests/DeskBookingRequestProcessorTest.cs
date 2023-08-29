using Xunit;
using Moq;
using System;
using DeskBooker.Core;


namespace DeskBooker.Tests;

public class DeskBookingRequestProcessorTest
{
    private readonly DeskBookingRequestProcessor processor;
    private readonly DeskBookingRequest deskBookingRequest;
    private readonly Mock<IDeskBookingRepository> deskBookingRepositoryMock;

    public DeskBookingRequestProcessorTest()
    {
        // Mocking Repo

        deskBookingRepositoryMock = new Mock<IDeskBookingRepository>(); 

        processor = new DeskBookingRequestProcessor(deskBookingRepositoryMock.Object);

        deskBookingRequest = new DeskBookingRequest
        {
            Firstname = "Mehedi",
            Lastname = "Hasan",
            Email = "mehedi@gmail.com",
            BookingDate = DateTime.Now
        };
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
}