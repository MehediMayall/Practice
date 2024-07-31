using static System.Console;


bool IsUpperCase(string str) => str.All(char.IsUpper);
bool IsLowerCase(string str) => str.All(char.IsLower);

bool IsPasswordCompitable(string str) => 
    str.Any(char.IsUpper) &&
    str.Any(char.IsLower) &&
    str.Any(char.IsDigit);


bool IsPasswordStrong(string str) => 
    str.Any(char.IsUpper) &&
    str.Any(char.IsLower) &&
    str.Any(char.IsDigit) &&
    "!@#$%^&*".ToCharArray().Any(c=> str.Contains(c));


bool IsPasswordSuperStrong(string str) =>
    str.Length is >=10 and <=20 &&
    str.Any(char.IsUpper) &&
    str.Any(char.IsLower) &&
    str.Any(char.IsDigit) &&
    "!@#$%^&*".ToCharArray().Any(c=> str.Contains(c)) &&
    str.ToCharArray().Distinct().Count() == str.Length;


WriteLine(IsLowerCase("Mehedi Hasan"));
WriteLine(IsUpperCase("Mehedi Hasan"));

WriteLine(IsPasswordCompitable("Mehedi123"));
WriteLine(IsPasswordStrong("Mehedi123"));
WriteLine(IsPasswordStrong("Mehedi@123"));

WriteLine(IsPasswordSuperStrong("Mehedi@123"));
WriteLine(IsPasswordSuperStrong("abcDxyz@123"));

