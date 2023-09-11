namespace Enumerations;

public static class ExtensionMethods
{
    public static int GetInt(this StatusCode enums)
    {
        return (int) enums;
    }
}