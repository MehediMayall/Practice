namespace DeskBooker.Core;

public class DeskBookingResult
{
    public string Firstname { get; set; } = "";
    public string Lastname { get; set;} = "";
    public string Email { get; set; } = "";
    public DateTime BookingDate { get; set; } = default;
}