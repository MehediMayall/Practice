using Xunit;
using System;
using DeskBooker.Core;


namespace DeskBooker.Tests;

public class DeskBookingRequestProcessorTest
{
    private readonly DeskBookingRequestProcessor processor;

    public DeskBookingRequestProcessorTest()
    {
        processor = new DeskBookingRequestProcessor();
    }


    [Fact]
    public void ShouldReturnDeskBookingResultWithRequest()
    {
        // Arrange
        var deskBookingRequest = new DeskBookingRequest
        {
            Firstname = "Mehedi",
            Lastname = "Hasan",
            Email = "mehedi@gmail.com",
            BookingDate = DateTime.Now
        };

        // Act
        DeskBookingResult deskBookingResult = processor.BookDesk(deskBookingRequest);

        // Assert
        Assert.Equal(deskBookingRequest.Firstname, deskBookingResult.Firstname);
        Assert.Equal(deskBookingRequest.Lastname, deskBookingResult.Lastname);
        Assert.Equal(deskBookingRequest.Email, deskBookingResult.Email);
        Assert.Equal(deskBookingRequest.BookingDate, deskBookingResult.BookingDate);
    }
}