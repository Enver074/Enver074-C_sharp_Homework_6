// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите несколько чисел: ");
string num = (Console.ReadLine()!);

Console.WriteLine($"Количество чисел больше 0 равно: {GetCount(num)}");


int GetCount(string number){
string[] array = number.Split(',');
int count = 0;
foreach (var item in array)
{
   int i = int.Parse(item);
   if(i > 0)
        count++;
}
return count;
}