﻿namespace Contacts.Maui.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string CombinedDetails => $"{this.Email} | {this.Phone}";
    }
}
