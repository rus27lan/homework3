// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// void num_AB (int A, int B)
// {
//     int count = 1;
//     int AB = 1;
//     while(count <= B)
//     {
//         AB = AB * A;
//         count++;
//     }
//     Console.WriteLine(AB);
// }
// Console.WriteLine("Ведите число для возведения в степень: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("В какую степень возвести? ");
// int numB = Convert.ToInt32(Console.ReadLine());
// num_AB(numA,numB);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// void sum_num (int num)
// {
//     int sum_num = 0;
//     int sum = 0;
//     if (num > 1)
//     {
//         while (num > 1)
//         {
//             sum = num % 10;
//             num = num / 10;
//             sum_num = sum_num + sum;
//         }
//         Console.WriteLine(sum_num);
//     }
//     else
//     {
//         Console.WriteLine("0");
//     }
// }
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// sum_num(number);

// Задача 29: (необязательная) Напишите программу, которая создает массив из введенных через запятую цифр и выводит этот массив на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
