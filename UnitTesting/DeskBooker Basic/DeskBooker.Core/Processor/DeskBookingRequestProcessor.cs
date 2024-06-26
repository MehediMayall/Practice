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

        var result = MapObject<DeskBookingResult>(request);
        result.ResultCode = DeskBookingResultCode.SUCCESS;

        if( DeskRepo.GetAvailableDesk(request.BookingDate).FirstOrDefault() is Desk availableDesk)
        {
            deskBooking =  MapObject<DeskBooking>(request);
            deskBooking.DeskId = availableDesk.Id;
            result.BookingId = request.BookingId;
            this.repo.Save(deskBooking);
        }
        else result.ResultCode = DeskBookingResultCode.NO_DESK_AVAILABLE;

        return result;
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