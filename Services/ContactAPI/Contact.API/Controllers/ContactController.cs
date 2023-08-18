using Contact.Infrastructure;
using Contact.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers;

[Route("/api/[controller]")]
public class ContactController : ControllerBase
{
    private readonly ILogger<ContactController> _logger;
    private readonly IContactService _contactService;

    public ContactController(ILogger<ContactController> logger, IContactService contactService)
    {
        _logger = logger;
        _contactService = contactService;
    }

    [HttpGet]
    public ActionResult GetActionResult(int id)
    {
        ContactDto contact = _contactService.GetContactById(id);

        return Ok(contact);
    }


}
