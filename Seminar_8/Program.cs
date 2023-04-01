// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int colums = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int [rows,colums];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0,10); 
//         Console.Write(array[i,j]+ " ");
//     }
//     Console.WriteLine();
// }

// int maxIndex = array.GetLength(0)-1;

// for (int j = 0; j < array.GetLength(1); j++)
// {
//    int temp=array[0,j];
//    array[0,j]=array[maxIndex,j];
//    array[maxIndex,j]=temp;
// }
// Console.WriteLine();
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
        
//         Console.Write(array[i,j]+ " ");
//     }
//     Console.WriteLine();
// }


// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int [rows,rows];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0,10); 
//         Console.Write(array[i,j]+ " ");
//     }
//     Console.WriteLine();
// }
// int [,] arraynew = new int [rows,rows];
// Console.WriteLine();

// for (int i = 0; i < arraynew.GetLength(0); i++)
// {
//     for (int j = 0; j < arraynew.GetLength(1); j++)
//     {
//         arraynew[i,j] =array[j,i]; 
//         Console.Write(arraynew[i,j]+ " ");
//     }
//     Console.WriteLine();
// }


// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.


// Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк:");
// int colomns = Convert.ToInt32(Console.ReadLine());

// int minValue = int.MaxValue;
// int minIndexRows=0;
// int minIndexColomns=0;

// int [,] array = new int [rows,rows];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0,10); 
//         Console.Write(array[i,j]+ " ");

//         if (minValue>array[i,j])
//         {
//          minValue=array[i,j];
//          minIndexRows=i;
//          minIndexColomns=j;
//         }
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();

// for (int i = 0; i < array.GetLength(0); i++)
// {
//    if (i!=minIndexRows)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//         if (j!=minIndexColomns)
//         {
//          Console.Write(array[i,j]);
//         }
//       }
//    }
    
//     Console.WriteLine();
// }