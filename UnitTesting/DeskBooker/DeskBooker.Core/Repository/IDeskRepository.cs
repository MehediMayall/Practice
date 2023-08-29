using System.Collections.Generic;

namespace DeskBooker.Core;

public interface IDeskRepository
{
    List<Desk> GetAvailableDesk(DateTime BookingDate);
}