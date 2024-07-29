// C# allows user defined types to control assignment and casting through the
// use of the implicit and explicit keywords. The signature of the method takes the form

// public static <implicit/explicit> operator <ResultingType>( <SourceType> obj);

using ImplicitExplicitCasting;

using static System.Console;


Error error = new Error(){
    Title = "This is a sample error",
    Detail = "This is a message detail for sample error"
};

Response response = error;      // Implicit casting, not mentioning type
Response response1 = (Response) error; 

WriteLine(response);
WriteLine(response1);

Error error2 = (Error) response;  // Explicit casting, mentioning type
List<Error> error3 = (List<Error>) response;  // Explicit casting, mentioning type

WriteLine(error2.Detail);
WriteLine(error3.FirstOrDefault().Detail);


// Creating Point Struct from Tuple
Point point = (45, 20);
Point point2 = (10.5f, 20.4f);

WriteLine($"X: {point.X}, Y: {point.Y}");
