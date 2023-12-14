
using LockExample;

Console.WriteLine("Hello, Lock!");

BankAccount accountA = new(100);
BankAccount accountB = new(100);

BankAccountService bankAccountService = new BankAccountService();

Task.Run(()=> bankAccountService.Transfer(accountA, accountB, 10));
Task.Run(()=>bankAccountService.Transfer(accountB, accountA, 20));

Console.WriteLine(accountA.Balance);
Console.WriteLine(accountB.Balance);


Console.ReadKey();
