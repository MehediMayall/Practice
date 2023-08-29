/*

## ICollection<T>, ICollection ##

ICollection<T> is the standard interface for countable collection of objects.
It provides the ability to determind the size of a collection (Count), determine whether an
item exists in the collection (Contains), copy the collection into an array(ToArray), and
determine whether the collection is read-only (IsReadOnly).

For writable collections, you can also add, remove and clear items for the collection.
Because it extends IEnumerable<T>, it can also be traversed via the foreach statement.


public interface ICollection<T> : IEnumerable<T>, IEnumerable
{
    int Count { get; }
    bool Contains(T item);
    void CopyTo (T[] array, int arrayIndex);
    bool IsReadOnly { get; }

    void Add(T item);
    bool Remove(T item);
    void Clear();
} 


## IList<T>, IList ##

IList<T> is the standard interface for collections indexable via position. In addition to the
functionality inherited from ICollection<T> and IEnumerable<T>, it provides the ability to read 
or write an element by position (via an indexer) and add or remove an item via position.

public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable
{
    T this[int index] { get; set;}
    int IndexOf(T item);
    void Insert(int index, T item);
    void RemoveAt(int index);
}

*/

using System.Collections;

string s = "Mehedi Hasan";

IEnumerator enu = s.GetEnumerator();

while (enu.MoveNext()){
    Console.WriteLine(enu.Current);
}


