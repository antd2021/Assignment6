namespace Assignment6;

public partial class ContactPage : ContentPage
{
    public List<ContactGroup> ContactList = new List<ContactGroup>();
    public ContactPage()
    {
        InitializeComponent();

        ContactList.Add(new ContactGroup("A", new List<Contact>
        {
            new Contact {Name="Anthony DiNinno", ImageName="pic1.PNG", Description="Student", PhoneNumber="(123)-456-7890", Email="adininno@example.com"},
            new Contact {Name="Aliene Bowers", ImageName="pic2.PNG", Description="Architect", PhoneNumber="(123)-456-7890", Email="abowers@example.com"},
            new Contact {Name="Ainsley Pike", ImageName="pic4.PNG", Description="Researcher", PhoneNumber="(123)-456-7890", Email="apike@example.com"}
        }));
        ContactList.Add(new ContactGroup("B", new List<Contact>
        {
            new Contact {Name="Benjamin Carter", ImageName="pic3.PNG", Description="Professor", PhoneNumber="(987)-654-3210", Email="bcarter@example.com"},
            new Contact {Name="Beatrice Hale", ImageName="pic4.PNG", Description="Researcher", PhoneNumber="(555)-123-4567", Email="bhale@example.com"},
            new Contact {Name="Brandon Mills", ImageName="pic1.PNG", Description="Software Engineer", PhoneNumber="(111)-222-3333", Email="bmills@example.com"}
        }));

        ContactList.Add(new ContactGroup("C", new List<Contact>
        {
            new Contact {Name="Catherine Rogers", ImageName="pic2.PNG", Description="Doctor", PhoneNumber="(444)-555-6666", Email="crogers@example.com"},
            new Contact {Name="Charles Davidson", ImageName="pic3.PNG", Description="Architect", PhoneNumber="(777)-888-9999", Email="cdavidson@example.com"},
            new Contact {Name="Carla Simmons", ImageName="pic4.PNG", Description="Artist", PhoneNumber="(222)-333-4444", Email="csimmons@example.com"}
        }));

        ContactList.Add(new ContactGroup("D", new List<Contact>
        {
            new Contact {Name="Daniel Foster", ImageName="pic1.PNG", Description="Musician", PhoneNumber="(666)-777-8888", Email="dfoster@example.com"},
            new Contact {Name="Diana Hughes", ImageName="pic2.PNG", Description="Writer", PhoneNumber="(333)-444-5555", Email="dhughes@example.com"},
            new Contact {Name="Derek Stone", ImageName="pic3.PNG", Description="Photographer", PhoneNumber="(888)-999-0000", Email="dstone@example.com"}
        }));

        ContactList.Add(new ContactGroup("E", new List<Contact>
        {
            new Contact {Name="Edward Blake", ImageName="pic1.PNG", Description="Pilot", PhoneNumber="(555)-666-7777", Email="eblake@example.com"},
            new Contact {Name="Elena Martin", ImageName="pic4.PNG", Description="Chef", PhoneNumber="(999)-000-1111", Email="emartin@example.com"},
            new Contact {Name="Elliot Sanders", ImageName="pic1.PNG", Description="Entrepreneur", PhoneNumber="(123)-789-4560", Email="esanders@example.com"}
        }));

        Contacts.ItemsSource = ContactList;
    }

    private void Contact_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as Contact;
        if (selectedItem == null) return;
        Navigation.PushAsync(new ContactDetails(selectedItem));
        ((CollectionView)sender).SelectedItem = null;
    }
}
