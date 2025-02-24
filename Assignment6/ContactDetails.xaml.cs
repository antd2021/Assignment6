namespace Assignment6;

public partial class ContactDetails : ContentPage
{
	public ContactDetails(Contact person)
	{
		InitializeComponent();
        PersonImage.Source = person.ImageName;
        LblPersonName.Text = $"Name: {person.Name}";
        LblPersonDesc.Text = $"Description: {person.Description}";
        LblPhone.Text = $"Phone: {person.PhoneNumber}";
        LblEmail.Text = $"Email: {person.Email}";
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}