// Задача №46 Задайте двумерный массив размером m х n,
// заполненный случайными целыми числами.
// m=3, n=4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.WriteLine("Введите число:");
int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
int columns=Convert.ToInt32(Console.ReadLine());

int[,] array=new int[rows,columns];

for (int i = 0; i < array.GetLength(0); i++)              //в GetLength(0)-это строчки, GetLength(1)-это столбцы
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j]= new Random().Next(0,10);
        Console.Write(array[i,j]+" ");
    }
    Console.WriteLine();
}

// Задача №48. Задайте двумерный массив размера m на n,каждый элемент в массиве
// находится по формуле: A(mn)=m+n
// Ведите полученный массив на экран.
// m=3,n=4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.WriteLine("Введите количество строк:");
// int rows=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] array=new int[rows,columns];

// for (int i = 0; i < array.GetLength(0); i++)              
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j]= i+j;
//         Console.Write(array[i,j]+" ");
//     }
//     Console.WriteLine();
// }

// Задача 49. Задайте двумерный массив.Найдите элементы, у которых
// оба индекса четные, и замените эти элементы на их квадраты.
//  Например, массив      Новый массив будет такой:
//  выглядел так:
//  1 4 7 2                     1 4 49 2 
//  5 9 2 3                     5 9 2 3
//  8 4 2 4                     64 4 4 4

// Console.WriteLine("Введите количество строк:");
// int rows=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] array=new int[rows,columns];

// for (int i = 0; i < array.GetLength(0); i++)            
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j]= new Random().Next(0,10);
//         Console.Write(array[i,j]+" ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();

// for (int i = 0; i < array.GetLength(0); i++)            
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if ((i%2==0)&&(j%2==0))
//         {
//             array[i,j]= array[i,j]*array[i,j];
//         }
//         Console.Write(array[i,j]+" ");
//     }
//     Console.WriteLine();
// }



// Задача 51. Задайте двумерный массив.Найдите сумму элементов,
//  находящихся на главной диагонали(с индексами(0,0);(1,1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2=12


// Console.WriteLine("Введите количество строк:");
// int rows=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int columns=Convert.ToInt32(Console.ReadLine());

// int sum=0;

// int[,] array=new int[rows,columns];

// for (int i = 0; i < array.GetLength(0); i++)            
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j]= new Random().Next(0,10);

//         if (i==j)
//         {
//             sum=sum+array[i,j];     //sum+=array[i,j];
//         }
//         Console.Write(array[i,j]+" ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Сумма элементов на главной диагонали равна:"+sum);



// ********С выводом решения как в примере:***********

// Console.WriteLine("Введите количество строк:");
// int rows=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int columns=Convert.ToInt32(Console.ReadLine());

// int sum=0;
// int arrayLength=0;
// int[,] array=new int[rows,columns];

// if (rows>columns)
// {
// arrayLength=columns;
// }
// else
// {
//     arrayLength=rows;
// }

// int[]array2=new int[arrayLength];

// for (int i = 0; i < array.GetLength(0); i++)            
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j]= new Random().Next(0,10);

//         if (i==j)
//         {
//             sum=sum+array[i,j];  
//             array2[j]=array[i,j];   
//         }
//         Console.Write(array[i,j]+" ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Сумма элементов на главной диагонали равна:");

// for (int i = 0; i < array2.Length; i++)
// {
//     Console.Write(array2[i]+"+");
// }
// Console.WriteLine("="+sum);