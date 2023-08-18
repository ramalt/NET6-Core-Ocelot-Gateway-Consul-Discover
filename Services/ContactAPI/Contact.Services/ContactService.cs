using Contact.Infrastructure;
using Contact.Models;

namespace Contact.Services;

public class ContactService : IContactService
{
    public ContactDto GetContactById(int id)
    {
        return new ContactDto()
        {
            Id = id,
            FirstName = "Ramazan",
            LastName = "Altuntepe",

        };
    }
}
