// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, -567, 89, 223-> 3

Console.WriteLine("Введите количество чисел для проверки: ");
int num = Convert.ToInt32(Console.ReadLine());
void main(int num)
{
    Console.WriteLine("Введите эти числа по одному: ");
    int i = 0;
    int [] array = new int [num];
    while (i<num) 
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
    int j = 0;
    int numbers = 0;
    while(j<array.Length)
    {
        if(array[j]>0)numbers++;
        j++;
    }
    Console.WriteLine($"---> {numbers}");
}
main (num);

// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// // значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение k2");
// double k2 = Convert.ToInt32(Console.ReadLine());
// void point(double b1,double k1,double b2,double k2)
// {
//     double X1= b1-b2;
//     double X2= k1-k2;
//     double X = -X1/X2;
//     double Y = (k2*X)+b2;
//     Console.WriteLine($"({X}; {Y})");
// }
// point(b1,k1,b2,k2);



// Задача 6семинар - необязательная: Напишите программу, на вход которой подаётся размерность матрицы и потом прямоугольная матрица в виде последовательности строк. .
// Программа должна вывести матрицу того же размера, у которой каждый элемент в позиции i, j равен сумме элементов первой матрицы на позициях (i-1, j), (i+1, j), (i, j-1), (i, j+1). У крайних символов соседний элемент находится с противоположной стороны матрицы.
// В случае одной строки/столбца элемент сам себе является соседом по соответствующему направлению.
// Sample Input 1:
// 3
// 9 5 3
// 0 7 -1
// -5 2 9
// Sample Output 1:
// 3 21 22
// 10 6 19
// 20 16 -1
// Sample Input 2:
// 1
// 1
// Sample Output 2:
// 4
