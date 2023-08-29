using System;

namespace WineFactory;


public class Sentence
{
    public string[] words = "To implementing an indexer, define a property called this.".Split();


    // using indexer
    // Read and write
    // public string this[int x]   
    // {
    //     get {return words[x];}
    //     set {words[x] = value;}
    // }

    // Read-only
    public string this[int x] => words[x];

    // using Range on indexer
    public string[] this[Range range]=> words[range];
}


// Static Constructor

public class Cat
{
    static Cat(){ Console.WriteLine("Static constructor initialized");}
    public Cat(){Console.WriteLine("Normal Constructor Initialized");}


    // Module Initializer
    [System.Runtime.CompilerServices.ModuleInitializer]
    public static void initCat(){
        Console.WriteLine("InitCat is called");
    }

    public static void sampleMethod() => Console.WriteLine("You have called sample method");

    ~Cat()=> Console.WriteLine("Class finalizer is being called before the garbase collector reclaims the memory for an unreferenced object");
}


// Partial Class and method 
partial class UserAccount
{
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public string UserName {get;set;}
    public string Password {get;set;}
    public int Age {get;init;} = 0;


    // Partial method defination
    public partial Boolean IsPasswordValidated();
}

partial class UserAccount
{
    public UserAccount(string UserName, string Password)
    {
        this.UserName = UserName;
        this.Password = Password;
    }

    // Partial method implementation
    public partial Boolean IsPasswordValidated()
    {
        if(this.UserName == "Admin" && this.Password == "SuperSecretPassword") return true;
        else return false;
    }
}



public class WineFactory
{
    public static void print(string message) => Console.WriteLine(message);

    public static void Main(string[] args)
    {
        // Sentence sentence= new Sentence();
        // Console.WriteLine(sentence[3]);

        // Console.WriteLine(sentence[new Range(0,3)]);
        // Console.WriteLine(sentence[..2]);
        // Console.WriteLine(sentence[1..4]);

        // Static Constructor

        // Cat cat2 = new Cat();
        Cat.sampleMethod();

        Console.WriteLine("Before calling initCat");
        Cat.initCat();

        
        UserAccount user = new UserAccount("Admin", "SuperSecretPassword");
        if(user.IsPasswordValidated()) print($"{user.UserName}");
        

        

    }
}