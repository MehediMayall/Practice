using System.Collections.Generic;

namespace DeskBooker.Data;


public interface IDeskRepository
{
    List<Desk> GetAvailableDesk(DateTime BookingDate);
}