// Задача 40: Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон


//  Console.Write("Введитe первое число - сторона А");
//  int a = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введитe второе число- сторона В");
//  int b = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введитe третье число-сторона С");
//  int c = Convert.ToInt32(Console.ReadLine());

//  if (((b+c)>a)&&((a+c)>b)&&((a+b)>c))
//  {
//  Console.WriteLine("Треугольник существует");
//  }
//  else 
// {
// Console.WriteLine("Треугольник не существует");
// }


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1=num;
// int i = 0;
// while(num1>0)
// {
//     num1=num1/2;
//     i++;
// }
// int[] array = new int[i];

// for (int j = 0; j < i; j++)
// {
//     array[i-j-1]=num%2;
//     num=num/2;
// }
    
// Console.WriteLine(String.Join("",array));


// Задача 42:Второе решение

// Console.WriteLine("Number = ");
// int n = Convert.ToInt32(Console.ReadLine());
// string counter = "";

// while (n >= 1)
// {
//    counter = (n % 2) + counter;
//    n = n / 2;
// }
// Console.WriteLine(counter);

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Enter number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int num1 = 0;
// int num2 = 1;

// int num3 = 1;
// Console.WriteLine(num1);
// Console.WriteLine(num2);
// for (int i = 2; i < num; i++)
// {
//     num3 = num1 + num2;
//     Console.WriteLine(num3);
//     num1 = num2;
//     num2 = num3;
// }


// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.


// int[] array = new int[]{6,7,321,15,0,7};
// int[] result = new int[array.Length];

// for (int i = 0; i < array.Length; i++)
// {
//    result[i] =array[i];
// }

// for (int i = 0; i < result.Length; i++)
// {
//    System.Console.WriteLine(result[i]);
// }