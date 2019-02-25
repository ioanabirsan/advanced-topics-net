using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonalAgenda
{
    [Serializable]
    public class PersonalAgenda
    {
        public List<Contact> Contacts;

        public PersonalAgenda()
        {
            Contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public void RemoveBy(string name, string firstName)
        {
            var contact = Contacts.FirstOrDefault(c => c.Name == name && c.FirstName == firstName);
            Contacts.Remove(contact);
        }

        public Contact FindBy(string name, string firstName)
        {
            return Contacts.FirstOrDefault(c => c.Name == name && c.FirstName == firstName);
        }
    }
}