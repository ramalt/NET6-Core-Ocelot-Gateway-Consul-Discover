using Contact.Models;

namespace Contact.Infrastructure;

public interface IContactService
{
    public ContactDto GetContactById(int id);
    
}
