using Task_1;

DelegateClass dg = new DelegateClass();
DelegateClass.NoParameters noparameters = new DelegateClass.NoParameters(dg.RandomNumbers);
Console.WriteLine(noparameters());