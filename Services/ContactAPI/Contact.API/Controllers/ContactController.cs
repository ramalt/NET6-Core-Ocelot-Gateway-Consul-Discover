using Contact.Infrastructure;
using Contact.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers;

[Route("/api/[controller]")]
public class ContactController : ControllerBase
{
    private readonly IContactService _contactService;

    public ContactController(IContactService contactService)
    {
        _contactService = contactService;
    }

    [HttpGet("{id}")]
    public ActionResult GetActionResult(int id)
    {
        ContactDto contact = _contactService.GetContactById(id);

        return Ok(contact);
    }


}
