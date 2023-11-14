using Contacts.Maui.Models;

namespace Contacts.Maui.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();
		var contacts = new List<Models.Contact>()
		{
			new Models.Contact{ Name = "John Smith", Email = "JohnSmith@gmail.com", Phone = "0888888888" },
            new Models.Contact{ Name = "Jane Smith", Email = "JaneSmith@gmail.com", Phone = "0888777777" },
            new Models.Contact{ Name = "George Best", Email = "GeorgeBest@gmail.com", Phone = "0888999999" },
        };

		listContacts.ItemsSource = contacts;
	}    
}