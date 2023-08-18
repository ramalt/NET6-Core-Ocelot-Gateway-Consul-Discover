using Reservation.Infrastructure;
using Reservation.Models;

namespace Reservation.Services;

public class ReservationService : IReservationService
{
    public ReservationDTO GetReservationByNumber(int reservatioNum)
    {
        return new ReservationDTO{
            Id = (new Random()).Next(100),
            Amounts = (new Random()).Next(10000),
            ResevationDate = DateTime.Now,
            CheckInDate = DateTime.Now.AddDays(2),
            CheckOutDate = DateTime.Now.AddDays(3),
            ReservatioNum = reservatioNum

        };
    }
}
