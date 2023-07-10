/*  Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.
int CutNumber(int num)

{
    int hundreds = num / 100;
    int units = num % 10;
    int result = hundreds * 10 + units;
    return result;
}

int randNumber = new Random().Next(100, 1000);
int newNumber = CutNumber(randNumber);

Console.WriteLine($"New version {randNumber} is {newNumber}");
*/

// Напишите программу, которая принимает на вход 
// число и проверяет, кратно ли оно одновременно a и b

bool isDividable(int num, int a, int b);
{
    if (num / a == 0 && num % b == 0) return true;
    else return false;
}

Console.WriteLine("Input number for checking: ");
int number1 = Convert.ToInt32.(Console.ReadLine());
Console.WriteLine("Input a first divider: ");

int number2 = Console.ReadLine();




// Напишите программу, которая выводит случайное 
// число из отрезка [10, 99] и показывает наибольшую цифру числа.


// Напишите программу, которая принимает на вход 
// два числа и проверяет, является ли одно число квадратом другого