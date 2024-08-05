using static System.Console;

// here x is an object of Base Class and referenced it to the Base class
Base x = new Base();

// here y is an object of Derived class and referenced it to the Base class
Base y = new Derived();

// It is possible to access base class functions from any base or derived object 
x.DoSomething();

// this is how Object Substitution principle works on regular types
y.DoSomething();

WriteLine($"x is {x.GetType()} type");
WriteLine($"y is {y.GetType()} type");


// Here, it is not possible to access derived functions from an object of derived class
// which is referenced to base class. 
// Both Base and Derived classes are General type where covariance is not possible  
// y.DoMore();


Derived d = new Derived();
d.DoMore();
d.DoSomething();


// Variance is all about augmenting Object Substitution Principle to work for generic types, objects



interface IProducer<out T> // here out T means covariant type
{
    T Produce();
}

interface IConsumer<T>
{
    void Consume(T obj);
}



class Base
{
    public void DoSomething() => 
        WriteLine($"Doing from {this.GetType().Name}");
}

class Derived : Base
{
    public void DoMore() => 
        WriteLine($"Doing from {this.GetType().Name}");

}