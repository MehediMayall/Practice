namespace WineFactory;


/* There are 8 Modifiers in C#

1. Static Modifier - Static
2. Access Modifier - public, private, internal, protected
3. Inheritence Modifier - new, virtual, abstract, override, sealed
4. Unsafe code Modifier - unsafe, extern
5. Read only modifier - readonly
6. Threading modifier - volatile
7. Asynchronous code modifier - async
8. Partial method modifier - partial


The Readonly modifier prevents a field from being modified after construction. A readonly field can be assigned only its declaration

readonly string RootPath = "C:\";


Expression-bodied method

int Foo(int x) => x * 2;
int SayHello(string message) => Console.WriteLine(message);


Local Method

You can define a method within a method using Expression-bodied method.

void writeCubes(){
    Console.WriteLine(cube(3));
    Console.WriteLine(cube(4));
    Console.WriteLine(cube(5));

    int cube(int x) => x * x * x; 
}


Deconstructing Assignment

(double height, double width) = rect;



## Expression-bodied Properties

public decimal Worth => currentPrice * sharesOwned;



## Partial method has definition and an implementation. They cannot accept out parameter.



## Nondestructive mutation

with Keyword, to perform nondestructive mutation on records

var items = new { A=1, B=2, C=3, D=4}
var allItems = items with {E=5, F=6}


*/

// using System.IO;

// Console.WriteLine("Hello World!");
