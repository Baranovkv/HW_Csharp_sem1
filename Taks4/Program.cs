﻿Console.WriteLine("Enter the first whole number, please");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second whole number, please");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third whole number, please");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
Console.WriteLine($"Maximum: {max}");