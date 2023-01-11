//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("Enter an integer, please");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2 > 0) Console.WriteLine("No, the nuber is odd"); // если отстаток от деления больше нуля, то выводим, что число нечетное
else Console.WriteLine("Yes, the number is even"); // иначе выводим, что число четное