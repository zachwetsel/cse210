public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime dateTime, Address address, string rsvpEmail)
    : base(title, description, dateTime, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}Type: Reception\nRSVP Email: {_rsvpEmail}\n";
    }
}