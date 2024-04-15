/*
Collection:
A class that provides in-memory management of a group of items.
*/

using static System.Console;

int[] numbers = {3,5,9,6};
WriteLine(numbers[^2]);

var book = new {
    Title = "C# in Depth",
    Publisher = "Unkown",
    NumberOfPages = 566
};

Write(book.GetType());
WriteLine(book.Title);




