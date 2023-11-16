using System.Runtime.CompilerServices;
using Contact = Contacts.Maui.Models.Contact;

namespace Contacts.Maui.Repositories
{
    public static class ContactRepository
    {
        public static List<Contact> contacts = new List<Contact>()
        {
            new Contact{ Id = 1, Name = "John Smith", Email = "JohnSmith@gmail.com", Phone = "0888888888" },
            new Contact{ Id = 2, Name = "Jane Smith", Email = "JaneSmith@gmail.com", Phone = "0888777777" },
            new Contact { Id = 3, Name = "George Best", Email = "GeorgeBest@gmail.com", Phone = "0888999999" },
        };

        public static List<Contact> GetContacts() => contacts;

        public static Contact GetContactById(int id)
        {
            var contact = contacts.FirstOrDefault(x => x.Id == id);
            if (contact != null)
            {
                return new Contact
                {
                    Id = id,
                    Name = contact.Name,
                    Email = contact.Email,
                    Phone = contact.Phone,
                    Address = contact.Address
                };
            }

            return null;
        }

        public static void EditContact(int id, Contact contact)
        {
            if (id != contact.Id)
            {
                return;
            }

            var contactToEdit = contacts.FirstOrDefault(x => x.Id == id);
            if (contactToEdit != null)
            {
                contactToEdit.Name = contact.Name;
                contactToEdit.Email = contact.Email;
                contactToEdit.Phone = contact.Phone;
                contactToEdit.Address = contact.Address;
            }
        }

        public static void AddContact(Contact contact)
        {
            var id = contacts.Max(x => x.Id) + 1;
            contact.Id = id;
            contacts.Add(contact);
        }

        public static void DeleteContact(int id)
        {
            var contact = contacts.FirstOrDefault(x => x.Id == id);
            if (contact != null)
            {
                contacts.Remove(contact);
            }
        }

        public static List<Contact> SearchContact(string text)
        {
            return contacts.Where(x => x.Name.StartsWith(text, StringComparison.OrdinalIgnoreCase))?.ToList();         
        }
    }
}
