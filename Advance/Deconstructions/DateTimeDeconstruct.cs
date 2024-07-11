namespace Deconstructions;

public static class DateTimeDeconstruct
{
    public static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day) =>
        (year, month, day) = (dateTime.Year, dateTime.Month, dateTime.Day);
    
}