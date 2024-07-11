using PatternMatching;
using static System.Console;


void NullCheck(object obj)
{
    if( obj is string str)
        System.Console.WriteLine(str.ToUpper());
    else
        System.Console.WriteLine($"{nameof(obj)} is not a string");
}

NullCheck("Hello world");
NullCheck(23);


// --

string Properties(object obj)
{
    if(obj is Pet{ Weight: >1000, PetType: PetType.Fish})
        return "It must be a whale shark!";
    
    if( obj is Pet)
        return "It's some pet";

    return "Definately not a pet";
}


var pet1 = new Pet(1200, PetType.Fish);
var pet2 = new Pet(2, PetType.Fish);

WriteLine(Properties(pet1));
WriteLine(Properties(pet2));
WriteLine(Properties(null));