// Задача 24: Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.Write("Введитe число");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetSumNum()
// {
//     int sum=0;
//     int count=0;

//     while(count<num)
//     {
//         count++;
//         sum+=count;
       
//     }

//     return sum;
// }

// Console.WriteLine(GetSumNum());


// Задача 26: Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число:");
// string number = Console.ReadLine();
// int num= number.Length; 
// Console.WriteLine("колличество цифр в числе " +num);

// Второе решение

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 0;

// while (num > 0)
// {
//     num /=10;     
//     count++;
// }
// Console.WriteLine($"Количество цифр = {count}");

// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int factorial = 1;
// int count = 1;

// while(count<=num)
// {
//     factorial *=count;
//     count++;
// }

// Console.WriteLine($"Произведение чисел равно {factorial}");

// Задача 30: Напишите программу, которая выводит массив 
// из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int [8];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i]=new Random().Next(0,2);
//     Console.WriteLine(array[i]);
// }
