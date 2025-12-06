// See https://aka.ms/new-console-template for more information
Console.Write("Enter your name: ");
string name = Console.ReadLine() ?? "World";

Console.Write("Enter your age:");
int age = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Nice to meet you, {name}. You are {age} years old1 ");