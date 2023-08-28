/*
Array Class

Array class is the implicit base class for all single and multidimensional arrays and it it one
of most fumdamental types implementing standard collection interfaces.
*/



using System.Collections;
using System.Text;

void print(object message)=> System.Console.WriteLine(message);

object[] A = {"Mehedi","Hasan",35};
object[] B = {"Mehedi","Hasan",35};


// Equality Test: Comparing Object A with Object B
print(A.Equals(B));



// Structural Equality test:
IStructuralEquatable se1 = A;

print(se1.Equals(B, StructuralComparisons.StructuralEqualityComparer));


// Arrays can be duplicate by calling Clone method
object[] C = (object[]) B.Clone();

print(C);


// String Builder

StringBuilder[] Country = new StringBuilder[5];
Country[0] = new StringBuilder("Bangladesh");
Country[1] = new StringBuilder("India");
Country[2] = new StringBuilder("Australia");



StringBuilder[] Country2 = Country;
StringBuilder[] Country3 = (StringBuilder[]) Country.Clone();

print(Country[0]);
print(Country2[0]);
print(Country3[0]);

Country[0] = new StringBuilder("USA");

print(Country[0]);
print(Country3[0]);



