// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Enter any number: ");
string inputedString = Console.ReadLine(); // Console reads the user's input
int number = Convert.ToInt32(inputedString);

if (number %2 == 0)
{
    Console.WriteLine($"The number {number} is even.");
}
else
{
    Console.WriteLine($"The number {number} is odd.");
}
