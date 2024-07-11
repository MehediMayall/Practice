namespace Attributes;

[AttributeUsage(AttributeTargets.Property)]
class StringLengthValidate: Attribute
{
    public StringLengthValidate(int minLength, int maxLenth)
    {
        MinLength = minLength;
        MaxLenth = maxLenth;
    }

    public int MinLength { get; }
    public int MaxLenth { get; }
}
