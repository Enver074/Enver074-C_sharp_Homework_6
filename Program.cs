// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

// Console.WriteLine("Введите несколько чисел: ");
// string num = (Console.ReadLine()!);

// Console.WriteLine($"Количество чисел больше 0 равно: {GetCount(num)}");


// int GetCount(string number){
// string[] product = number.Split(',');
// int count = 0;
// foreach (var item in product)
// {
//    int i = int.Parse(item);
//    if(i > 0)
//         count++;
// }
// return count;
// }



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.WriteLine("Введите b1: ");
// int b1 = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите k1: ");
// int k1 = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите b2: ");
// int b2 = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите k2: ");
// int k2 = int.Parse(Console.ReadLine()!);

// int x = (b2 - b1) / (k1 - k2);
// int y = k2 * x + b2;

// Console.WriteLine($"Точка пересечения заданных прямых: ({x},{y})");



// Найти произведение всех элементов массива целых чисел, меньших заданного числа. Размерность массива –10. Заполнение массива осуществить случайными числами от 50 до 100.

int[] product = GetProduct(10, 50, 100);

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine($"В массиве [{String.Join(", ", product)}] произведение чисел меньше {num} равно: {multiplication(product)}");

int multiplication(int[] product){
    int sum = 1;
    for(int i = 0; i < product.Length; i++){
        if (product[i] < num)
            sum *= product[i];}
    return sum;
}

int[] GetProduct(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}


