using Contacts.Maui.Repositories;
using Contact = Contacts.Maui.Models.Contact;

namespace Contacts.Maui.Views;

[QueryProperty(nameof(Id),"Id")]
public partial class EditContactPage : ContentPage
{
	private Contact contact;
	public EditContactPage()
	{
		InitializeComponent();
	}

    public string Id 
	{
		set 
		{
			this.contact = ContactRepository.GetContactById(int.Parse(value));
			if (this.contact != null)
			{
				contactCtrl.Name = this.contact.Name;
                contactCtrl.Email = this.contact.Email;
                contactCtrl.Phone = this.contact.Phone;
                contactCtrl.Address = this.contact.Address;
            }
		}
	}

    private async void btnCancel_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
    }

    private async void btnEdit_Clicked(object sender, EventArgs e)
    {
		this.contact.Name = contactCtrl.Name;
		this.contact.Email = contactCtrl.Email;
		this.contact.Phone = contactCtrl.Phone;
		this.contact.Address = contactCtrl.Address;

		ContactRepository.EditContact(contact.Id, this.contact);
        await Shell.Current.GoToAsync("..");
    }

    private void contactCtrl_OnError(object sender, string e)
    {
		DisplayAlert("Error", e, "OK");
    }
}