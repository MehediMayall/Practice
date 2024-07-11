namespace Attributes;

public class Validator
{
    public bool Validate(object obj)
    {
        var type = obj.GetType();
        var propertiesToValidate = type
            .GetProperties()
            .Where(p=> Attribute.IsDefined(p, typeof(StringLengthValidate)));

        foreach(var property in propertiesToValidate)
        {
            object propertyValue = property.GetValue(obj);
            _ = propertyValue is string ? "" : 
                throw new InvalidOperationException($"Attribute {nameof(StringLengthValidate)} can only be applied to string" );

            var value = (string) propertyValue;
            var attribute = (StringLengthValidate) property.GetCustomAttributes(typeof(StringLengthValidate), true).First();

            if(value.Length< attribute.MinLength || value.Length > attribute.MaxLenth)
                return false;
        }

        return true;
    }
}