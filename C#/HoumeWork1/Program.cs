// Task 1. Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int CutNumber(int number)
{
    int dozens = number / 10;
    int unit = dozens %10;
    int result = unit;
    return result; 
}
int randNumber = new Random().Next(100, 1000);
int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/

// Task 2. Напишите программу, которая выводит третью цифру заданного числа

int thirdDigit(int number)
{
    int newNumber = number % 100;
    int result = newNumber;
    return result; 
}
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100) Console.WriteLine(number + "-" + "Некорректное число");
while (number >= 1000) 
{
      newNumber = number / 10;
    else newNumber = newThirdDigit(hirdDigit);
}


// Task 3. Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

