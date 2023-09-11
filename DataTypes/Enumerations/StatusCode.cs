namespace Enumerations;

public enum StatusCode: uint
{
    Ok=200,
    BadRequest = 300,
    NotFound = 400,

    ServerError = 500,

    Unknown = 100

}