// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число А");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число В");
// int B = Convert.ToInt32(Console.ReadLine());

// Console.Write(Math.Pow(A,B));



// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число:");
// string number = Console.ReadLine();

// int sum = 0;
// for (int i = 0; i < number.Length; i++)
// {
//   string str =Convert.ToString(number[i]);
//   int num1 = Convert.ToInt32(str);
  
//   sum = sum + num1;
// }
// Console.WriteLine(sum);



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] array = {1,2,5,7,19};
// void PrintArray (int[] array)
// {
//     int count=array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine($"{array[i]}");
//     }
//     Console.WriteLine();
// }

// PrintArray(array);


// Вариант 2:

// int [] array=new int [8];
    
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,100);

//     }

// Console.Write(String.Join(" ",array));
