namespace DeskBooker.Core;

public class DeskBookingRequestProcessor
{
    public DeskBookingResult BookDesk(DeskBookingRequest request)
    {
        if (request == null) throw new ArgumentNullException(nameof(request));
        
        return new DeskBookingResult{
            Firstname = request.Firstname,
            Lastname = request.Lastname,
            Email = request.Email,
            BookingDate = request.BookingDate,
        };
    }
}