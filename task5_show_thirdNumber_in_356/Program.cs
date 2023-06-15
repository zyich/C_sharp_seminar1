/* Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

Console.Write("vvedite trehznachnoe chislo");
float n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n % 10);

//float число с плавающей запяток 
// n % 10 это остаток от деления на 10 
