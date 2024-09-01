using Microsoft.AspNetCore.DataProtection;

public class AuthService
{
    private readonly IDataProtectionProvider idp;
    private readonly IHttpContextAccessor contextAccessor;

    public AuthService(IDataProtectionProvider idp, IHttpContextAccessor contextAccessor)
    {
        this.idp = idp;
        this.contextAccessor = contextAccessor;
    }

    public void SignIn()
    {
        var protector = idp.CreateProtector("auth-cookie");
        this.contextAccessor.HttpContext.Response.Headers["set-cookie"] =  $"auth={ protector.Protect("usr:mehedi") }";
    }
}