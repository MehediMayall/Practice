/*
Patterns

C# has 6 patterns:

> Type patterns
> Conjuctive 'and' patterns
> Disjuctive 'or' patterns
> Negative 'not' patterns
> Parenthesized patterns
> Relation patterns
*/



void print(object message)=> System.Console.WriteLine(message);



// VAR Pattern
bool IsAdminUser(string UserName)=>
    UserName.ToUpper() is var User && (User == "ADMIN" || User == "SYSADMIN"); 


// Constant Pattern
bool isVATPercentCorrect(object VATPercent)=> VATPercent is 16.5;

// Property Pattern
bool validatePasswordLength(object Password) => Password is string and {Length : >= 8 and <=20};


// VAR Pattern
print(IsAdminUser("admin"));
print(IsAdminUser("default"));


// Constant Pattern
print(isVATPercentCorrect(20.4));
print(isVATPercentCorrect(16.5));


// Propery Pattern
print("\r\nProperty Pattern");

print($"When password length not valid : {validatePasswordLength("pass")}");
print($"When Password is null: {validatePasswordLength(null)}");
print(validatePasswordLength("SuperSecret"));
print(validatePasswordLength("HereIsMySuperSecretPassword"));


// public class Program
// {
//     public static void Main(string[] args)
//     {

//     }
// }