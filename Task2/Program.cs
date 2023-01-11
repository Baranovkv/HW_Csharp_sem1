// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Enter the first whole number, please"); // запрашиваем первое число
int number1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Enter the second whole number, please"); // запрашиваем второе число
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2) //проверяем числа на равенство/больше/меньше
{
    Console.WriteLine($"Maximum = {number1}, Minimum = {number2}");
}
else if (number1 < number2) 
{
    Console.WriteLine($"Maximum = {number2}, Minimum = {number1}");
}
else Console.WriteLine("Numbers are equals");