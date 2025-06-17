using System.Diagnostics.Contracts;

namespace CharpNotes;

[ContractClassFor(typeof(IWork))]
internal abstract class MyContract: IWork
{
    private MyContract(){}

    public string DoSomeWork(string Input)
    {
        Contract.Requires(!string.IsNullOrEmpty(Input));
        Contract.Ensures(!string.IsNullOrEmpty(Contract.Result<string>()));
        throw new NotSupportedException();
    }
}


