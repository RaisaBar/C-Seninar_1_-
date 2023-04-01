// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Введите количество элементов массивa");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[m];
// int count = 0;

// for (int i = 0; i < m; i++)
// {
//     Console.WriteLine($"Введите {i + 1} элемент массива");
//     array[i] = Convert.ToInt32(Console.ReadLine());
//     if (array[i] > 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine(String.Join(", ", array));
// Console.WriteLine($"Чисел больше ноля {count}");


//************Второе решение задачи****************


// int count = 0;
// int max=int.MaxValue;
// int num=0;

// for (int i = 0; i < max; i++)
// {
//     Console.WriteLine("Введите  число,если закончили введите %");
//     string number= Console.ReadLine();

//  if (number=="%")
//     {
//         break; 
//     }
//     num= Convert.ToInt32(number);
//     if ( num>0)
// { 
//     count++;
// }
// }
// Console.WriteLine("Пользователь ввел "+count+" шт. чисел больше 0");



// Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите число b1, k1");
// double b1 = Convert.ToDouble(Console.ReadLine());
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите число b2, k2");
// double b2 = Convert.ToDouble(Console.ReadLine());
// double k2 = Convert.ToDouble(Console.ReadLine());
// double x = (b1 - b2) / (k2 - k1);
// double y = k1 * x + b1;
// if (k1 == k2)
//     Console.WriteLine("Прямые не пересекаются ");

// else
// {
//     Console.WriteLine("Прямые пересекаются в координатаx" + x + y);
// }

