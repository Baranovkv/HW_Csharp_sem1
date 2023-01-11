Console.WriteLine("Enter an integer, please");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2 > 0) Console.WriteLine("The nuber is odd"); // если отстаток от деления больше нуля, то выводим, что число нечетное
else Console.WriteLine("The number is even"); // иначе выводим, что число четное