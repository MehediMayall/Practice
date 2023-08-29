namespace DeskBooker.Core;

public interface IDeskBookingRepository
{
    DeskBooking Save(DeskBooking request);
}