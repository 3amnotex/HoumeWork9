// Task 1. Задайте массив заполненный случайными положительными трёхзначными числами.
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

// Task 2.  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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

// Task 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

float[] RealNumbersArray(int size)
{
    float[] array = new float[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = (float)random.NextDouble() * 10;
    }
    return array;
} 
void PrintArray(float[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

float DifferentialMaxMin(float[] array)
{
    float min = array[0];
    float max = array[0];

    for (int i = 0; i < array.Length; i++)
     {
        if (array[i] > max) 
            max = array[i];
        else if (array[i] < min) 
            min = array[i];
     }
    return  max - min;
}

Console.WriteLine("Введите размер массива: ");
int Length = Convert.ToInt32(Console.ReadLine());

float[] myArray = RealNumbersArray(Length);
PrintArray(myArray);

float result = DifferentialMaxMin(myArray);
Console.WriteLine("Разность двух вещественных чисел =" + result);


    