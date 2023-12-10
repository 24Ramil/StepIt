
using Proxy_Pattern.Bank;
using Proxy_Pattern.Proxy;


IBankAccount account = new ProxyBankAccount();

while (true) 
{
	Console.Clear();
	Console.WriteLine("1.Add");
	Console.WriteLine("2.Spend");
	Console.WriteLine("3.Show Balance");
	Console.Write("Enter operation: ");
	int selectedIndex;
	int.TryParse(Console.ReadLine(), out selectedIndex);

	switch (selectedIndex)
	{
		case 1:
			double amount;
			Console.Write("Enter amount: ");
			Double.TryParse(Console.ReadLine(), out amount);
			account.AddAmount(amount);
			break;

		case 2:
			Console.Write("Enter amount: ");
			Double.TryParse(Console.ReadLine(), out amount);
			account.Spend(amount);
			break;
		case 3:
			Console.WriteLine($"Balance: {account.GetBalance()}");
			break;
		default:
			Console.WriteLine("Incorrect operation!");
			break;
	}
	Thread.Sleep(5000);
}