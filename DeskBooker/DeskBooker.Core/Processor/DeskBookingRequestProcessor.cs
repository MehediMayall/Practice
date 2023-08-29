namespace DeskBooker.Core;

public class DeskBookingRequestProcessor
{
    private readonly IDeskBookingRepository repo;
    public DeskBookingRequestProcessor(IDeskBookingRepository Repo)
    {
        this.repo = Repo;   
    }

    public DeskBookingResult BookDesk(DeskBookingRequest request)
    {
        if (request == null) throw new ArgumentNullException(nameof(request));

        this.repo.Save(MapObject<DeskBooking>(request));

        return MapObject<DeskBookingResult>(request);
    }

    public T MapObject<T>(DeskBookingRequest request) where T : DeskBooking, new()
    {
        return new T
        {
            Firstname = request.Firstname,
            Lastname = request.Lastname,
            Email = request.Email,
            BookingDate = request.BookingDate
        };
    }
}