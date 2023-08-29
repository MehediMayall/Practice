/*
## Boxing: 
Boxing is the act of converting a value-type instance to a reference-type instance.

int x = 9;
object obj = x; // here x is boxed to reference-type instance

## Unboxing
Unboxing is the act of converting a reference-type instance to a value-type instance.

int y = (int) x;


1. Numeric Conversion
    int value = (int) 3.5;

2. Reference Conversion

3. Boxing Conversion

    object obj = value;

*/

static void print(object message) => Console.WriteLine(message);

int x= 9;
object obj = x;

print(x.GetType());
print(obj);
print(obj.GetType());

x = 33;
print(obj);  // obj = 9;

int y = (int)obj;       // 9
print(y);       // y = 9
print(y.GetType());

obj = 44;
print(obj);     
print(y);  // y stil 9