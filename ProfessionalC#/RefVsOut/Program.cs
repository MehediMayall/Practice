using static System.Console;

int value1 = 10;
int value2 = 10;

multiplyItRef(ref value1);
multiplyItOut(out value2);


// Ref can reuse previous value
void multiplyItRef(ref int num) => num = num * 10;

// Out can't reuse preivous value. It must assign the value in the function
void multiplyItOut(out int num) 
{
    num = 1;
    num = num * 10;
}

WriteLine($"Using ref, value1 = {value1}");
WriteLine($"Using out, value1 = {value2}");

