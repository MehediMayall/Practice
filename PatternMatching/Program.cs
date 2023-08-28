// Pattern matching using swtich case
string getWeightCategory(decimal bmi) => bmi switch {
        < 18.5M => "Underweight",
        < 25M => "Normal",
        < 30M => "Overweight",
        _=> "obese"
        };

// Pattern matching for vowel
bool isVowel(char c) => c is 'a' or 'e' or 'i' or 'o' or 'u';

// Pattern matching for letter
bool isLetter(char c) => c is >='a' and <='z' or >='A' and <='Z';

Console.WriteLine(getWeightCategory(bmi:23.8M));

Console.WriteLine("Checking vowel");

Console.WriteLine(isVowel('c'));
Console.WriteLine(isVowel('a'));


Console.WriteLine("Checking letter");

Console.WriteLine(isLetter('9'));
Console.WriteLine(isLetter('C'));
Console.WriteLine(isLetter('y'));
Console.WriteLine(isLetter('O'));


