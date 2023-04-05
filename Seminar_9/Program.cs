// Задача 63: Задайте значение N. Напишите программу, которая
//  выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.WriteLine("Введите число");
// int num =int.Parse(Console.ReadLine());

// int count =1;

// int PrintNumber()
// {
//   if(count>num)
//   {
//     return count;
//   }
 
//   Console.Write(count+" ");

//   count++;

//   return (PrintNumber());
// }

// PrintNumber();


// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// Console.WriteLine("Введите число M");
// int M  =int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число N");
// int N =int.Parse(Console.ReadLine());
// int count =M;

// int PrintNumber()
// {
//     if (count>N)
//     {
//         return count;
//     }

//   Console.Write(count+" ");

//   count++;

//   return (PrintNumber());
// }

// PrintNumber();



// Задача 67: Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.WriteLine("Введите число M");
// int num =int.Parse(Console.ReadLine());
// int sum=0;
// int GetSum()
// {
//     if (num/10>0)
// }

// Console.WriteLine("Введите число M");
// int n =int.Parse(Console.ReadLine());
// int result = GetResult(n);
// Console.Write($"{n} -> {result}");


// int GetResult(int n)
// {
//     if (n == 0) return 0;
//     else
//     {
        
//         GetResult(n - 1);
//         return n%10 + GetResult(n/10);
//     }
// }


// Задача 69: Напишите программу, которая на вход принимает 
// два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


// Console.WriteLine("Введите число a");
// int a  =int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число b");
// int b =int.Parse(Console.ReadLine());

// int GetResult(int a, int b)
// {
//     if (b == 1) return a;
//     return (a*GetResult(a, b-1));
    
// }
// Console.WriteLine(GetResult(a,b));