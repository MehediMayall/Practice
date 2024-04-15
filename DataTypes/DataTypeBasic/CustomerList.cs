namespace DataTypeBasic;

public class CustomerList
{
    public List<Customer> Customers;

    // Expression bodied member
    public int Count => Customers.Count();


    // Expression bodied function
    public IEnumerator<Customer> GetEnumerator() => Customers.GetEnumerator();  

}