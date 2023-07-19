// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// int[] CreateNewArray(int size)
// {
//     int[] array = new int[size];

//     for (int i = 0; i  < array.Length; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int RandomPositiveNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)  count++;
        
//     }
//     return count;
// }

// Console.Write("Input a Length of array: ");
// int Length = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateNewArray(Length);
// PrintArray(myArray);
// int positiveNumbers = RandomPositiveNumbers(myArray);
// Console.WriteLine("Количество четных чисел в массиве = " + positiveNumbers);

//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] NewArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-20, 20);
    }
    return array;
}
    int OddPositionSum(int[] array)
    {
        int sum = 0;
        for(int i = 1; i < array.Length; i +=2)
        {
            sum += array[i];
        }
        return sum;
    }

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.WriteLine("Введите размер массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] myArray = NewArray(Length);
PrintArray(myArray);
int SumPosition = OddPositionSum(myArray);
Console.WriteLine(SumPosition);