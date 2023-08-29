namespace DeskBooker.Core;

public class DeskBookingRequestProcessor
{
    private readonly IDeskBookingRepository repo;
    private readonly IDeskRepository DeskRepo;


    public DeskBookingRequestProcessor(IDeskBookingRepository Repo, IDeskRepository DeskRepo)
    {
        this.repo = Repo;
        this.DeskRepo = DeskRepo;   
    }

    public DeskBookingResult BookDesk(DeskBookingRequest request)
    {
        if (request == null) throw new ArgumentNullException(nameof(request));
        var deskBooking = new DeskBooking();

        if( DeskRepo.GetAvailableDesk(request.BookingDate).FirstOrDefault() is Desk availableDesk)
        {
            deskBooking =  MapObject<DeskBooking>(request);
            deskBooking.Id = availableDesk.Id;
            this.repo.Save(deskBooking);
        }


        return MapObject<DeskBookingResult>(request);
    }

    


    private T MapObject<T>(DeskBookingRequest request) where T : DeskBooking, new()
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