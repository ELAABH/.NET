namespace AM.ApplicationCore.Domain
{
    public class Passenger


      public string PassportNumber { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime BirthDate { get; set; }
    public int? TelNumber { get; set; }
    public string? EmailAddress { get; set; }


    public override string ToString()
    {
        return "FirstName: " + FirstName + " LastName: " + LastName + " date of Birth: " + BirthDate;
    }
    public List<flight> flights { get; set; } = new List<flight>();
}