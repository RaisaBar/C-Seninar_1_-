// Задача 31: Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел
// равна 29, сумма отрицательных равна -20.

// int[] array = new int [12];

// int positiveSum=0;
// int negSum=0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i]=new Random().Next(-9,10);

//     if (array[i]>0)
//     {
//         // positiveSum=positiveSum+array[i];
//         positiveSum+=array[i];
//     }

//     else if (array[i]<0)
//     {
//         negSum+=array[i];
//     }
// }
// Console.WriteLine(String.Join(", ",array));
// Console.Write($"Сумма положительных ={positiveSum}, а отрицательных{negSum}");


// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] array = new int[] {-4, -8, 8, 2};

// for (int i = 0; i < array.Length; i++) 
//     array[i]*=-1;

// Console.WriteLine(string.Join(", ",array));


// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// bool b =false;

// int[] array = new int [8];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i]=new Random().Next(0,5);

//     if (num==array[i])
//     {
//         b=true;
//     }
    
// }

// if (b==true)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }
// Console.Write(String.Join(", ", array));


// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


// int [] array = new int [10];
// int count = 0;

// for (int i=0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(0, 120);

//     if ((array[i]>9)&&(array[i]<100))
//     {
//         count++;
//     }
// }
// Console.WriteLine(String.Join(",", array));
// Console.WriteLine(count);


// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] array = new int [] {1,2,3,4,5};
// int[] array2 = new int[array.Length/2+array.Length%2];

// for (int i = 0; i < array2.Length; i++)
// {
//    array2[i]=array[i]*array[(array.Length-1)-i];

//    if (i==(array.Length-1)-i)
//    {
//     array2[i]=array[i];
    
//    }
// }

// Console.WriteLine(String.Join(", ", array));
// Console.WriteLine(String.Join(", ", array2));
