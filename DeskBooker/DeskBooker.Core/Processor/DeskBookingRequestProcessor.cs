namespace DeskBooker.Core;

public class DeskBookingRequestProcessor
{
    public DeskBookingResult BookDesk(DeskBookingRequest request)
    {
        return new DeskBookingResult{
            Firstname = request.Firstname,
            Lastname = request.Lastname,
            Email = request.Email,
            BookingDate = request.BookingDate,
        };
    }
}