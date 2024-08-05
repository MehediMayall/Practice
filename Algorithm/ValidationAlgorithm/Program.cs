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


// bool IsValid(string word) {
//     string str = word.ToLower();
//     return "aeiou".ToCharArray().Any(c=> str.Contains(c)) && 
//         "abcdfgjklmnpqrstvxyz".ToCharArray().Any(c=> str.Contains(c)) &&
//         str.Select(char.IsLetter).Count() >= 3 &&
//         new System.Text.RegularExpressions.Regex(@"[^\w]").Match(str).Length == 0;
// }

bool IsValid(string word) {
    string str = word.ToLower();     

    var containsVowel = new System.Text.RegularExpressions.Regex(@"[aeiou]");
    var containsConsoant = new System.Text.RegularExpressions.Regex(@"[^aeiou\d]");
    var containsOnlyLetters = new System.Text.RegularExpressions.Regex(@"[^\w]");

    return    str.Length >= 3 &&
        containsVowel.IsMatch(str) && 
        containsConsoant.IsMatch(str) &&
        containsOnlyLetters.Matches(str).Count == 0;
}


// WriteLine(IsLowerCase("Mehedi Hasan"));
// WriteLine(IsUpperCase("Mehedi Hasan"));

// WriteLine(IsPasswordCompitable("Mehedi123"));
// WriteLine(IsPasswordStrong("Mehedi123"));
// WriteLine(IsPasswordStrong("Mehedi@123"));

// WriteLine(IsPasswordSuperStrong("Mehedi@123"));
// WriteLine(IsPasswordSuperStrong("abcDxyz@123"));


WriteLine(IsValid("234Adas"));
WriteLine(IsValid("b3"));

