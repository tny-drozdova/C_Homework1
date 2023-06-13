// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Enter a number (N): ");
string inputedString = Console.ReadLine();
int N = Convert.ToInt32(inputedString);

Console.WriteLine($"Even numbers from 1 to {N}:");

int X = 2;  // The variable X is larger than 1, but less than N, and is even
while (X <= N)
{
    Console.WriteLine(X);
    X += 2;
}