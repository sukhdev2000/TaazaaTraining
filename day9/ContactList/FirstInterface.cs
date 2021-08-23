using day9.ContactList;
using day9.Models;
using System.Collections.Generic;
namespace day9
{
    public interface FirstInterface
    {
         int createContact(Contact objContact);
         List<Contact> DisplayList();
         void deleteContact(int index);
         void updateContact(int index);
         Contact Search(int index);
    }
}