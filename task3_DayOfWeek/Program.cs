﻿/* Задача №3. Напишите программу, которая
 будет выдавать название дня недели 
 по заданному номеру.
3 -> Среда
5 -> Пятница
*/

Console.WriteLine("vveditr chislo: ");
int n = Convert.ToInt32(Console.ReadLine());

Dictionary<int, string> map = new Dictionary<int, string>()
{
    {1, "Ponedelnik"},
    {2, "Vtornik"},
    {3, "Sreda"},
    {4, "Chetverg"},
    {5, "Pyatnica"},
    {6, "Subbota"},
    {7, "Voskr"},
};
if (n > 0 && n < 8)
{
    Console.WriteLine(map[n]);
}
else
{
    Console.WriteLine($"Oshibka!");
}

//дикшанари это словарь в который помщаем массив с инт и стринг(ключ и значение) 
// мап название словаря 