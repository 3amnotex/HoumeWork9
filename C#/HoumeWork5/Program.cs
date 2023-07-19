// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] CreateNewArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i  < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int RandomPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)  count++;
        
    }
    return count;
}

Console.Write("Input a Length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateNewArray(Length);
PrintArray(myArray);
int positiveNumbers = RandomPositiveNumbers(myArray);
Console.WriteLine("Количество четных чисел в массиве = " + positiveNumbers);
