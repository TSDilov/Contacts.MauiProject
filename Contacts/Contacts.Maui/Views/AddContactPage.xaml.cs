using Contacts.Maui.Repositories;
using Contact = Contacts.Maui.Models.Contact;

namespace Contacts.Maui.Views;

public partial class AddContactPage : ContentPage
{
	public AddContactPage()
	{
		InitializeComponent();
	}

    private async void contactCtrl_OnSave(object sender, EventArgs e)
    {
        var contact = new Contact
        {
            Name = contactCtrl.Name,
            Email = contactCtrl.Email,
            Phone = contactCtrl.Phone,
            Address = contactCtrl.Address,
        };

        ContactRepository.AddContact(contact);
        await Shell.Current.GoToAsync("..");
    }

    private async void contactCtrl_OnCancel(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private void contactCtrl_OnError(object sender, string e)
    {
        DisplayAlert("Error", e, "OK");
    }
}