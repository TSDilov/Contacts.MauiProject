namespace Contacts.Maui.Models
{
    public class Contact
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string CombinedDetails => $"{this.Email} | {this.Phone}";
    }
}
