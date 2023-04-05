// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int colums = Convert.ToInt32(Console.ReadLine());

// double [,] array = new double [rows,colums];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().NextDouble()*10; 
//         Console.Write("{0,6:F2}", array[i,j]);
//     }
//     Console.WriteLine();
// }


// ********* решение задачи с помощью Math.Round********* 

// Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int colums = Convert.ToInt32(Console.ReadLine());

// double [,] array = new double [rows,colums];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//        array[i, j] = Math.Round(new Random().NextDouble()*10, 2);
//         Console.Write(array[i,j]+"  " );
//     }
//     Console.WriteLine();
// }


// Задача 50. Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемент
// или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите индекс строки:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите индекс столбца:");
// int colums = Convert.ToInt32(Console.ReadLine());
// int n = 5;
// int m = 7;
// int [,] array = new int [n,m];
// Console.WriteLine("Исходный масив:");

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0,10);
//         Console.Write(array[i,j]+ " ");
//     }
//     Console.WriteLine();
// }
// if (rows < 0 |rows > array.GetLength(0)-1 | colums <0 | colums > array.GetLength(1)-1 )
// {
//     Console.WriteLine("Такого элемента не существует.");
// }
//  else
//  {
//     Console.WriteLine("Значение элемента масства = {0}", array[rows, colums]);
//  }



// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Console.WriteLine("Введите количество строк:");
// int rows=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] array=new int[rows,columns];
// double sum=0;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0,10);
//         Console.Write(array[i,j]+ " ");
//     }
//     Console.WriteLine();
// }
// for (int j = 0; j < array.GetLength(1); j++)
// {
//     sum=0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum+=array[i,j];
//     }
//  Console.WriteLine($"Среднее арифметическое столбца: {sum/array.GetLength(0)}");
// }