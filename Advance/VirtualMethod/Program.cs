namespace VirtualMethod;

public class UserAccount
{
    public int Id { get; set; }
    public string UserName { get; set; } = "";
    public string Password { get; set; } = "";

    public UserAccount(string UserName, string Password) => (this.UserName, this.Password) = (UserName, Password);

    public virtual Boolean validateUser() => (UserName, Password) == ("Admin", "SuperSecret") ? true : false;
}



// ## Relationship between two classes using Inheritance
// public class SecureAccount : UserAccount // Inheritance 
// {
//     public SecureAccount(string UserName, string Password) : base(UserName, Password){}
//     public override bool validateUser() =>  (UserName, Password) == ("Admin", "SuperSecret") ? true : false;
// }


// Relation between two classes using Composition
public class SecureAccount
{
    private readonly UserAccount userAccount;
    public SecureAccount(UserAccount userAccount) => this.userAccount = userAccount;

    public bool validateUser() =>  (userAccount.UserName, userAccount.Password) == ("Admin", "SuperSecret") ? true : false;
}


public class VirtualMethod
{
    public static void print(object Message) => Console.WriteLine(Message);

    public static void Main(string[] args)
    {
        // SecureAccount secureAccount = new ("Admin","SuperSecret");
        // print(secureAccount.validateUser());

        // print(new SecureAccount("Admin","SuperSecret").validateUser()); // true
        // print(new SecureAccount("Admin","supersecret").validateUser()); // false
        // print(new SecureAccount("SuperSecret","Admin").validateUser()); // false

        print(new SecureAccount(new UserAccount("Admin", "SuperSecret")).validateUser());
    }
}

