namespace DeskBooker.Data;

public interface IDeskBookingRepository
{
    DeskBooking Save(DeskBooking request);
}