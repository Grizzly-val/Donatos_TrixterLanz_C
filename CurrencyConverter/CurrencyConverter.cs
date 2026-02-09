// See https://aka.ms/new-console-template for more information
Console.Write("Enter amount in USD: ");
double usd = double.Parse(Console.ReadLine()!);

Console.Write("Enter exchange rate from USD to EUR: ");
double eRate = double.Parse(Console.ReadLine()!);

double amount = usd * eRate;

Console.Write("Amount in EUR: {0:F2}", amount);
