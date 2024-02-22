public class Event
{
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private Address _address;

    public Event(string title, string description, DateTime dateTime, Address address)
    {
        _title = title;
        _description = description;
        _dateTime = dateTime;
        _address = address;
    }

    public string GenerateStandardDetails()
    {
        return $"Standard Details:\nTitle: {_title}\nDescription: {_description}\nDate: {_dateTime.ToShortDateString()}\nTime: {_dateTime.ToShortTimeString()}\nAddress: {_address}\n";
    }

    public virtual string GenerateFullDetails()
    {
        return GenerateStandardDetails();
    }

    public virtual string GenerateShortDescription()
    {
        return $"Short Description:\nType: Event\nTitle: {_title}\nDate: {_dateTime.ToString("MM/dd/yyyy")}\n";
    }
}