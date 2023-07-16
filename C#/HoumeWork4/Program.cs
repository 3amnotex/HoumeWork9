// Task 1. Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

        int degreeConversion(int number, int degree)
    {
        int result = 1;

        for (int i = 0; i < degree; i++)
        {
            result *= number;
        }

        return result;
    }
        int A = new Random().Next(1, 10);
        Console.WriteLine(A);
        //  Console.WriteLine("Введите число A:");
        // int A = Convert.ToInt32(Console.ReadLine());
        int B = new Random().Next(1, 10);
        Console.WriteLine(B);
        // Console.WriteLine("Введите число B:");
        // int B = Convert.ToInt32(Console.ReadLine());

        int result = degreeConversion(A, B);
        Console.WriteLine("Результат: " + result);

// Task 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumDigit(int number)
{   
    int sum = 0;
    while(number > 0)
    {       
       sum = sum + number % 10;
      
       number = number / 10;
    }
       return sum;
}
Console.WriteLine("Input number: ");
int dig = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumDigit(dig));

// Task 3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран. 
// Разработать метод CreateArray(int size), генерирующий массив на основе данных, вводимых пользователем.

 
    int[] CreateArray(int size)
    {
        int[] array = new int[size];
        Console.WriteLine("Введите элементы массива:");

        for (int i = 0; i < size; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        return array;
    }
    
     void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
        Console.WriteLine("Введите размер массива:");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] array = CreateArray(size);

        Console.WriteLine("Сгенерированный массив:");
        PrintArray(array);
        
    



