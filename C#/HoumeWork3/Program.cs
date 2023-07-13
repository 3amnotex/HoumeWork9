//  Task 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

    bool IsPalindrome(int number)
    {
        int originalNumber = number;
        int reversedNumber = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number = number / 10;
        }

        return originalNumber == reversedNumber;
    }
    
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPalindrome(number))
        {
            Console.WriteLine("Введенное число является палиндромом.");
        }
        else
        
            Console.WriteLine("Введенное число не является палиндромом.");

        
    
// Task 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

 double distance (int x1, int y1, int z1, int x2, int y2, int z2)
 {
    double sqrt = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + (z2 - z1) * (z2 - z1));
    return sqrt;
 }

Console.WriteLine("Input x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z2");
int z2 = Convert.ToInt32(Console.ReadLine());
double doub = distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(doub);
   
// Task 3.  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void TableCube(int N)
{
    int count = 1;
    while(count <= N)
    {
        Console.WriteLine($"{count} = {count * count * count}");
        count++;
    }
}
Console.WriteLine("Возведение числа в куб ");
Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

TableCube(num);
    