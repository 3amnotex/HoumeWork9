// Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
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

