// Task 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// int[] CreateArray (int size)
// {
//     int[] array = new int[size];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-20, 20);

// }
//     return array;
// }

// int GreaterThanZero (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count ++;
//     }
//     return count;

// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

//  Console.Write("Введите размер массива ");
//  int Length = Convert.ToInt32(Console.ReadLine());
//  int[] myArray = CreateArray (Length);
//  PrintArray(myArray);
//  int result = GreaterThanZero(myArray);
//  Console.WriteLine("Количество элементов больше нуля - " + result);

// Task 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


class Program
{
    static void Main()
    {
        Console.WriteLine("Введите размерность двумерного массива.");
        Console.Write("Количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Количество столбцов: ");
        int columns = int.Parse(Console.ReadLine());

        double[,] array = new double[rows, columns];

        Console.WriteLine("Введите значения для каждой ячейки массива:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = new Random().Next(100);
            }
        }

        Console.WriteLine("Двумерный массив:");
        PrintArray(array);

        FindIntersectionPoint(array);
    }

    static void PrintArray(double[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void FindIntersectionPoint(double[,] array)
    {
        if (array.GetLength(0) < 2 || array.GetLength(1) < 2)
        {
            Console.WriteLine("Массив должен содержать минимум две строки и два столбца.");
            return;
        }

        double b1 = array[0, 0];
        double k1 = array[0, 1];
        double b2 = array[1, 0];
        double k2 = array[1, 1];

        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine("x = (b2 - b1) / (k1 - k2) = " + x);
        Console.WriteLine("y = k1 * x + b1 = " + y);
        Console.WriteLine($"Точка пересечения имеет координаты: ({x}, {y})");
    }
}


