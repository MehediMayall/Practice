using Dumpify;


Try( () => Wrap(First));
// Try( () => Wrap(Second));
Wrap( () => Try(Second));



void First()=> "Executing first function".Dump();
void Second()=> "Executing second function".Dump();


void Wrap(Action function)
{
    "Start".Dump();
    function.Invoke();
    "End".Dump();
}

void Try(Action function)
{
    try{
        
        "Trying".Dump();
        function.Invoke();
    }
    catch(Exception ex) {ex.Dump();}
}