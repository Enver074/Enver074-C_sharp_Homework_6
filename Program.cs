// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

// Console.WriteLine("Введите несколько чисел: ");
// string num = (Console.ReadLine()!);

// Console.WriteLine($"Количество чисел больше 0 равно: {GetCount(num)}");


// int GetCount(string number){
// string[] array = number.Split(',');
// int count = 0;
// foreach (var item in array)
// {
//    int i = int.Parse(item);
//    if(i > 0)
//         count++;
// }
// return count;
// }



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите b1: ");
double b1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите k1: ");
double k1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите b2: ");
double b2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите k2: ");
double k2 = double.Parse(Console.ReadLine()!);

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;

Console.WriteLine($"Точка пересечения заданных прямых: ({x},{y})");