// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool palindrom (int num)
{
    if(num / 10000 == num % 10 && (num / 1000) % 10 == (num / 10) % 10) return true;
    else return false;
}

Console.WriteLine("Input numbers: ");
int numbers = Convert.ToInt32(Console.ReadLine());

bool num = palindrom(numbers); 
Console.WriteLine(num);



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double coordinates (double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double ABx = (x2-x1)*(x2-x1);
//     double ABy = (y2-y1)*(y2-y1);
//     double ABz = (z2-z1)*(z2-z1);
//     double AB = ABx+ABy+ABz;
//     double ABD = Convert.ToDouble(Math.Sqrt(AB));
//     return ABD;
// }
// Console.WriteLine("Input coordinates A: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// double y1 = Convert.ToDouble(Console.ReadLine());
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinates B: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// double y2 = Convert.ToDouble(Console.ReadLine());
// double z2 = Convert.ToDouble(Console.ReadLine());

// double ABD = coordinates(x1, y1, z1, x2 ,y2 , z2);
// Console.WriteLine(ABD);


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// *задача на каникулы 1 (необязательно) *
// Реализовать задачу про спираль из цифр https://github.com/TimurIslamgulov/DZ3 . Возможно, вам потребуются вложенные масивы, а может и нет )
// *задача на каникулы 2 (необязательно) *
// Реализовать игру с компьютером "Камень, ножницы , бумага". Игра может продолжаться несколько раундов, каждый раунд начисляются очки победителю.

// void NumberKub (int num)
// {
//     int count = 1;
//     int kub;
//     while (count < num)
//     {
//         kub = count * count * count;
//         Console.Write(kub + " ");
//         count++;
//     }
// }
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// NumberKub(number);