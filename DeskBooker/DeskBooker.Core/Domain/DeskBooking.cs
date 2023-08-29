namespace DeskBooker.Core;

public class DeskBooking
{
    public int Id { get; set; }
    public string Firstname { get; set; } = "";
    public string Lastname { get; set;} = "";
    public string Email { get; set; } = "";
    public DateTime BookingDate { get; set; } = default;
}