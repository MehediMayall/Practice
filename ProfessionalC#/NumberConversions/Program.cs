using static System.Console;

// Converting decimal to Binary, octal and hexa-decimal

uint num = 15;

// binary
Write("Binary: ");
WriteLine(Convert.ToString(num, 2));


// octal
Write("Octal: ");
WriteLine(Convert.ToString(num, 8));

// hexa-decimal
Write("Hexa-decimal: ");
WriteLine(Convert.ToString(num, 16));
