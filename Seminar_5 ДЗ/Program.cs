// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// int [] array = new int [5];
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//         array[i] = new Random().Next(100, 1000);

//    if (array[i]%2==0)
//   {
//     count++;
//   }
// }

// Console.WriteLine(String.Join(", ",array));
// Console.Write($"колличество четных чисел ={count}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int [] array = new int [4];

// for (int i = 0; i < array.Length; i++)
// {
//         array[i] = new Random().Next(0, 100);
 
// }
// Console.WriteLine(String.Join(", ",array));

// int sum=0;

// for (int i = 1; i < array.Length; i=i+2)
// {
// sum = sum+array[i];        
// }
// Console.Write($"Сумма элементов на нечетных позициях ={sum}");



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// int [] array = new int [5];


// for (int i = 0; i < array.Length; i++)
// {
//         array[i] = new Random().Next(0, 11);
 
// }

// int max = array[0];
// int min = array[0];

// for (int i = 0; i < array.Length; i++)
// {
//     if (max<array[i])  max=array [i];
//     if (min>array[i])  min=array[i];
// }

// Console.WriteLine(String.Join(", ",array));
// Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");