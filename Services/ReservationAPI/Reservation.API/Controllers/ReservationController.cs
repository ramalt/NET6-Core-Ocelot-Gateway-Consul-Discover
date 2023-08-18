using Microsoft.AspNetCore.Mvc;
using Reservation.Infrastructure;
using Reservation.Models;

namespace Reservation.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReservationController : ControllerBase
{
    private readonly IReservationService _reservationService;

    public ReservationController(IReservationService reservationService)
    {
        _reservationService = reservationService;
    }


    [HttpGet]
    public ActionResult GetReservation(int reservationNumber)
    {
        ReservationDTO reservation = _reservationService.GetReservationByNumber(reservationNumber);
        return Ok(reservation);
    }
}
