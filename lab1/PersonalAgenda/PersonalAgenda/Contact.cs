using System;
using System.Runtime.Serialization;

namespace PersonalAgenda
{
    [Serializable]
    public class Contact
    {
        public Contact(string name, string firstName, int age, string email, string phone, string other)
        {
            Name = name;
            FirstName = firstName;
            Age = age;
            Email = email;
            Phone = phone;
            Other = other;
        }
        
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        [OptionalField] public string Other;
    }
}