// See https://aka.ms/new-console-template for more information
Console.Write("Enter your name: ");
string name = Console.ReadLine() ?? "please type your name";

Console.Write("Enter your age:");
int age = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Nice to meet you, {name}. You are {age} years old ");

// 2. prints message to screen without moving to a new line, wait for user.
// 3.ReadLine() , reads whatever user types and returns the string, if null return text in q.marks.

// 5. same as number 2.
// 6. reads input as a string
//    if null , 0 is used . int.Parse connverts string to int
//8.  string interpolation, insert the variables

//   --- ask name ----> save it-----> ask age --> covert--> print string interpolation.
