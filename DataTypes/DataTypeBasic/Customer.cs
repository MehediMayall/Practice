namespace DataTypeBasic;

public class Customer
{
    public int Id { get; set; }    
    public string Name { get; set; }
    public string Email { get; set; }

    private Customer(int id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }

    public static Customer Create(int id, string name, string email)
    {
        return new Customer(id, name, email);
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Email: {Email}";
    }


}