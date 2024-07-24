using static System.Console;

// Left Shift
uint value = 15;
// shifting bit to left 
// 15 * 2 = 30 * 2 =  60 * 2 = 120 * 2 = 240 * 2 = 480

uint doubleValue = value << 5; 
WriteLine(doubleValue); // 480


// Right Shift
uint num = 960;

// 960 / 2 = 480 / 2 = 240
uint newValue = num >> 2;
WriteLine(newValue);    // 240
