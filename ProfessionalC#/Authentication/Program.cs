using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.DataProtection;

var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddDataProtection();
// builder.Services.AddHttpContextAccessor();
// builder.Services.AddScoped<AuthService>();

builder.Services.AddAuthentication("cookie")
    .AddCookie("");

var app = builder.Build();

app.UseAuthentication();

// Creating custom middle
// app.Use((context, next) =>{
//     var idp = context.RequestServices.GetRequiredService<IDataProtectionProvider>();    
//     var protector = idp.CreateProtector("auth-cookie");

//     var authCookcie = context.Request.Headers.Cookie.FirstOrDefault(x=> x.StartsWith("auth"));
//     var protectedPayload = authCookcie.Split("=").Last();
    
//     var payload = protector.Unprotect(protectedPayload);
//     var parts = payload.Split(":");
//     var (key,value) =  (parts[0], parts[1]);

//     var claims = new List<Claim>();
//     claims.Add(new Claim(key,value));

//     var identity = new ClaimsIdentity(claims);
//     context.User = new ClaimsPrincipal(identity);
    
//     return next();
// });

app.MapGet("/username", (HttpContext context, IDataProtectionProvider idp) => 
{
    
    return context.User.FindFirst("usr").Value;
    // return "No username is here";
});

app.MapGet("/login", async (HttpContext context) =>{

    var claims = new List<Claim>(){
        new Claim("usr","mehedi")
    };

    var identity = new ClaimsIdentity(claims);
    var user = new ClaimsPrincipal(identity);

    await context.SignInAsync("cookie", user);

    return "ok";
});

// app.MapGet("/login", (AuthService authService) =>{
//     authService.SignIn();
//     return "ok";
// });

app.Run();
