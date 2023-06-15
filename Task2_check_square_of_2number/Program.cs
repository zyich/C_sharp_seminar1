Console.Write("Vvedite chislo 1:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Vvedite chislo 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.Write($"da");
}
else
{
    Console.Write($"Net");
}

/* Задача №1. Напишите программу, которая на вход принимает два 
числа и проверяет, является ли первое
 число квадратом второго.
 */