namespace ImplicitExplicitCasting;

public class Response
{
    public string STATUS {get; set;}
    public object Data { get; set; }
    public List<Error> Errors { get; set; }

    public override string ToString()
    {
        string messages = "";
        foreach(var item in Errors) messages += $"title: {item.Title}, detail: {item.Detail}\n";
        return $"Status: {STATUS}, Data: {Data}, \nErrors: {messages}";
    }

    public static implicit operator List<Error>(Response response) => response.Errors;

}
