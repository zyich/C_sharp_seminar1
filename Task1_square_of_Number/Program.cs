Console.Write("Input number =>");
int number  = Convert.ToInt32(Console.ReadLine());
 // метод Конвертаци и тип 32 (кол-во символов в строке )

int power =  2; // степень числа
int squareNumber = (int)Math.Pow(number, power);
// можно решать проще : int squareNumber = number * number; 

Console.WriteLine($"Square {number} is {squareNumber}");
//$ используют для вывода дополнительного текста
