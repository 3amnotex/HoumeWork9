// Task 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int[] CreateArray (int size)
{
    int[] array = new int[size];
   
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-20, 20);
   
}
    return array;
}

int GreaterThanZero (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count ++;
    }
    return count;

}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

 Console.Write("Введите размер массива ");
 int Length = Convert.ToInt32(Console.ReadLine());
 int[] myArray = CreateArray (Length);
 PrintArray(myArray);
 int result = GreaterThanZero(myArray);
 Console.WriteLine("Количество элементов больше нуля - " + result);











// Task 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)