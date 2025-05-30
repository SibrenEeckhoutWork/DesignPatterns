using state;

VendingMachine VendingMachine = new VendingMachine();

VendingMachine.SelectProduct("Cola");
VendingMachine.Accept();
VendingMachine.InsertCoin();
Console.WriteLine("----------------------");
VendingMachine.Accept();
VendingMachine.InsertCoin();
VendingMachine.SelectProduct("Cola");
Console.WriteLine("----------------------");
VendingMachine.SelectProduct("Cola");
VendingMachine.InsertCoin();
VendingMachine.Accept();

