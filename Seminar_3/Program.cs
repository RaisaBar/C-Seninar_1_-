// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка

// Console.WriteLine("введите координаты X Y");
// int X=Convert.ToInt32(Console.ReadLine());
// int Y=Convert.ToInt32(Console.ReadLine());

// if ((X>0)&&(Y>0))
// {
// Console.WriteLine("Первая четверть");
// }

// else if ((X<0)&&(Y>0))
// {
// Console.WriteLine("Вторая четверть");
// }

// else if ((X<0)&&(Y<0))
// {
// Console.WriteLine("Третья четверть");
// }

// else 
// {
// Console.WriteLine("Четвертая четверть");
// }

// Напишите программу, которая по заданному номеру четверти, показывает
// диапазон возможных координат точек в этой четверти (x и y).

// Console.Write("Введи четверь");
// int number = Convert.ToInt32(Console.ReadLine());

// switch(number)
// {
//     case 1:
//     {
//         Console.Write("X>0 и Y>0");
//         break;
//     }
//     case 2:
//     {
//         Console.Write("X<0 и Y>0");
//         break;
//     }
//     case 3:
//     {
//         Console.Write("X<0 и Y<0");
//         break;
//     }
//     case 4:
//     {
//         Console.Write("X>0 и Y<0");
//         break;
//     }

//     default:
//     {
//         Console.Write("Такой четверти нет");
//         break;
//     }
    
// }

// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.Write("Введи X точки B");
// int XB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи Y точки B");
// int YB = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введи X точки A");
// int XA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи Y точки A");
// int YA = Convert.ToInt32(Console.ReadLine());


// double number =Math.Sqrt((Math.Pow ((XB-XA),2))+(Math.Pow ((YB-YA),2)));

//  Console.Write(number);


// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int i=1;

// while (i<=number)
// {
//     Console.Write(Math.Pow(i,2)+"  ");
//     ++i;
// }

// Другое решение этой задачи

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// for(int i=1; i<=number; i++)
// {
//      Console.WriteLine(Math.Pow(i,2));

// }

