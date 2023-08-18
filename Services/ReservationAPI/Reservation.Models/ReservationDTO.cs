using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservation.Models;

public class ReservationDTO
{
    public int Id { get; set; }
    public int ReservatioNum { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public DateTime ResevationDate { get; set; }
    public double Amounts { get; set; }
}
