using System.Net;
using static System.Console;



Task<string> antecedent = Task.Run(() => {
    Task.Delay(2000);
    return DateTime.Now.ToShortDateString();
});

Task<string> continuation = antecedent.ContinueWith(
    x => $"Today is {antecedent.Result}"
);


WriteLine(continuation.Result);

