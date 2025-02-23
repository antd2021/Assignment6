namespace Assignment6;

public partial class ContactDetails : ContentPage
{
	public ContactDetails(Contact person)
	{
		InitializeComponent();
        PersonImage.Source = person.ImageName;
        LblPersonName.Text = person.Name;
        LblPersonDesc.Text = person.Description;
    }
}