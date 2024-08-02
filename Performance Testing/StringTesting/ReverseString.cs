


namespace StringTesting;


[MemoryDiagnoser]
public class ReverseString
{
    string str = "";
    [Params(50,100)]
    public int SIZE = 50;

    [GlobalSetup]
    public void Setup()
    {
        str = "Write your answer here, and then test your code.";
    }

    [Benchmark (Baseline = true)]
    public void Run_ReverseUsingSystemFunction()
    {
        for(int x=0; x< SIZE; x++)
            ReverseUsingSystemFunction(str);
    }
    [Benchmark]
    public void Run_ReverseUsingStack()
    {
        for(int x=0; x< SIZE; x++)
            ReverseUsingStack(str);
    }

    [Benchmark]
    public void Run_ReverseRecursively()
    {
        for(int x=0; x< SIZE; x++)
            ReverseRecursively(str);
    }

    [Benchmark]
    public void Run_ReverseUsingStringBuilder()
    {
        for(int x=0; x< SIZE; x++)
            ReverseUsingStringBuilder(str);
    }
    
    [Benchmark]
    public void Run_ReverseUsingTwoPointer()
    {
        for(int x=0; x< SIZE; x++)
            ReverseUsingTwoPointer(str);
    }

    
    // Using Stack
    public string ReverseUsingStack(string str)
    {
        Stack<char> stack = new Stack<char>(str);
        StringBuilder sb = new StringBuilder();
        while (stack.Count > 0)
            sb.Append(stack.Pop());
        return sb.ToString();
    }
    

    // Built-in Function
    public string ReverseUsingSystemFunction(string str)
    {
        if ( string.IsNullOrEmpty(str) )
            return str;

        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
    

    // Recursively
    public string ReverseRecursively(string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;
        return ReverseRecursively(str.Substring(1)) + str[0];
    }

    public string ReverseUsingStringBuilder(string str)
    {
        if ( string.IsNullOrEmpty(str) )
            return str;

        StringBuilder sb =  new StringBuilder();
        for(int x= str.Length-1; x>=0; x --)
            sb.Append(str[x]);
        return sb.ToString();
    }

    // Using Two Pointer
    public string ReverseUsingTwoPointer(string str)
    {
        Span<char> chars = str.ToCharArray();
        int left = 0;
        int right = str.Length - 1;
        while (left < right)
        {
            (chars[left], chars[right]) = (chars[right],chars[left]);
            left++;
            right --;
        }
        return chars.ToString();
    }

    
    

}