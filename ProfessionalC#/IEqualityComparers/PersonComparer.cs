using System.Diagnostics.CodeAnalysis;

namespace IEqualityComparers;


// Two objects have been considered equal if both the Equals return true and
// the GetHashCode have returned the same hashcode for the two objects 
public class PersonComparer: IEqualityComparer<Person>
{
    public bool Equals(Person left, Person right) =>
        left.FullName == right.FullName && left.Email == right.Email;    

    public int GetHashCode([DisallowNull] Person obj) =>
        obj.FullName.GetHashCode() * obj.Email.GetHashCode();
    
}