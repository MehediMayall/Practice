/*
Null Handling

C# has 3 null handling operator

> Null Coalescing Operator

Order? order = GetOrder() ?? new();

> Null Coalescing Assignment

order ??= new();

> Null Forgiving Operator
order!.GenerateReport();

*/
