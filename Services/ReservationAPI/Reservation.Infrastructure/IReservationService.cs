using Reservation.Models;

namespace Reservation.Infrastructure;

public interface IReservationService
{
    public ReservationDTO GetReservationByNumber(int reservatioNum);
}
