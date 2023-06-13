Console.Write("Enter the first number out of three: ");
string inputedString1 = Console.ReadLine(); // Console reads the first input
int number1 = Convert.ToInt32(inputedString1); // The first input converted into int
Console.Write("Enter the second number out of three: ");
string inputedString2 = Console.ReadLine();
int number2 = Convert.ToInt32(inputedString2);
Console.Write("Enter the last out of three numbers: ");
string inputedString3 = Console.ReadLine();
int number3 = Convert.ToInt32(inputedString3);

int max = number1;

if (number2 > max)
{
    max = number2;
}

if (number3 > max)
{
    max = number3;
}
Console.WriteLine($"The maximum numer is {max}.");

