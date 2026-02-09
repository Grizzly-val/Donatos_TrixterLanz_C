// See https://aka.ms/new-console-template for more information
Console.Write("Enter principal amount: ");
double p = double.Parse(Console.ReadLine()!);

Console.Write("Enter rate of interest: ");
float r = float.Parse(Console.ReadLine()!);
Console.Write("Enter time in years: ");
int years = int.Parse(Console.ReadLine()!);

double simpleInterest = (p * r * years) / 100;

Console.Write("Simple interest: {0:F2}", simpleInterest);