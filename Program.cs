Console.WriteLine("Enter the first whole number, please");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second whole number, please");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    int max = number1;
    int min = number2;
    Console.WriteLine($"Maximum = {max}, Minimum = {min}");
}
else if (number1 < number2) 
{
    int max = number2;
    int min = number1;
    Console.WriteLine($"Maximum = {max}, Minimum = {min}");
}
else Console.WriteLine("Numbers are equals");