namespace CollectionDemo;


public class Employee
{
    public int id { get; set;}
    public string firstname { get; set; }
    public string lastname { get; set; }
    public string email { get; set; }
    public string gender { get; set; }
    public string country { get; set; }
    public string department { get; set; }
    public string company { get; set; }
    public string phone { get; set; }
    // public DateTime birthdate { get; set; }
    public string username { get; set; }

    public override string ToString()
    {
        return $"Name: {firstname} {lastname}, email: {email}, country: {country}";
    }
}