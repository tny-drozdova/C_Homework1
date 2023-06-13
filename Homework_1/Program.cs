// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Enter the first number: ");
string inputedString1 = Console.ReadLine();
int number1 = Convert.ToInt32(inputedString1);

Console.Write("Enter the second number: ");
string inputedString2 = Console.ReadLine();
int number2 = Convert.ToInt32(inputedString2);

if (number1 > number2)
{
    Console.WriteLine($"{number1} is greater number.");
    Console.WriteLine($"{number2} is smaller number.");
}
else if (number1 < number2)
{
    Console.WriteLine($"{number1} is smaller number.");
    Console.WriteLine($"{number2} is greater number.");
}
else
{
    Console.WriteLine($"{number1} and {number2} are equal.");
}
