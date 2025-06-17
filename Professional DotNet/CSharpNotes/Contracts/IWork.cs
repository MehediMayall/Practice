using System.Diagnostics.Contracts;

namespace CharpNotes;

[ContractClass(typeof(MyContract))]
public interface IWork
{
    string DoSomeWork(string Input);
}
