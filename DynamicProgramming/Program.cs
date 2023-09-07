using static System.Console;


// Static Binding
OutputTimeUsingStaticBinding();


// Dynamic Binding
OutputTimeUsingDynamicBinding();

GenerateRuntimeErrorUsingDynamicBinding();



void OutputTimeUsingStaticBinding()
{
    DateTime dateTime = DateTime.Now;
    string time = dateTime.ToLongTimeString();
    WriteLine(time);
}

void OutputTimeUsingDynamicBinding()
{
    dynamic dateTime = DateTime.Now;
    string time = dateTime.ToLongTimeString();
    WriteLine(time);
}

void GenerateRuntimeErrorUsingDynamicBinding()
{
    dynamic dateTime = DateTime.Now;
    string time = dateTime.IsCoffeeTime();
    WriteLine(time);
}