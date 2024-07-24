namespace ImplicitExplicitCasting;

public class Error
{
    public string Title { get; set; }
    public string Detail { get; set; }

    // Implicit Casting
    public static implicit operator Response(Error error) =>
        new Response(){ Data = null, Errors = new List<Error>{ error }, STATUS = "ERROR"};

    public static explicit operator Error(Response response) =>
        new Error{ 
                Title = response.Errors.FirstOrDefault().Title,
                Detail = response.Errors.FirstOrDefault().Detail
            };

    // public static explicit operator List<Error>(Response response2) => response2.Errors;
}