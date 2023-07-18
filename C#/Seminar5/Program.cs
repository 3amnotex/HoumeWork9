// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных элементов массива.

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
    
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int GetNegativeSum (int array)
// {
// int sum = 0;
// for (int i = 0; i < array.Length; i++) 
// {
//     if (array[i] < 0) sum += array[i];
// }
// return sum;
// }
// Console.Write("Input a length of array: ");
// int Length = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(length, min, max);
// int negativeSum =  GetNegativeSum (myarray);
// ShowArray(myArray);
// Console.WriteLine("sum = " + negativeSum);

// Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
    
//     return array;
// }
//  void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int[] NewArray (int[] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i]* (-1);                                                     

//     }
//     return array;
// }
// Console.Write("Input a length of array: ");
// int Length = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");                                    
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(Length, min, max);
// ShowArray( myArray);
// NewArray (myArray);                                                                                    
// ShowArray( myArray);


// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// int[] CreateNewRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);                       
    
//     return array;
// }
// bool  NewNumber (int[] a, int b)
// {
//     for( int i = 0; i < a.Length; i++)
//     {
//         if (a[i] == b) return true;
//     }
//     return false;
// }
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// Console.Write("Input a length of array: ");
// int Length = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");                                    
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input b: ");          
// int b = Convert.ToInt32(Console.ReadLine());

// int[] myArray2 = CreateNewRandomArray(Length, min, max);
// bool a = NewNumber(myArray2, b);
// ShowArray(myArray2);                                                              
// Console.Write(a);








        // Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
int[] CreateNewRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);                       
    
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
int SearchCount(int[]a, int b , int c)
{
    int count=0;
    for(int i=0; i<a.Length; i++)
    {
        if(a[i]>b&&a[i]<c)
        count++;

    }
return count;
}Console.Write("Input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");                                    
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a: ");                                    
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");                                    
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateNewRandomArray(Length, min, max);
 int w = SearchCount(myArray, a, b);
ShowArray(myArray);                                                              
Console.Write(w);