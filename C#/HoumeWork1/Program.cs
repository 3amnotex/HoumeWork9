// Task 1. Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.


/*int CutNumber(int number)
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

int cutThirdDigit(int number)
{
    while (number >= 1000)
    {
        number = number / 10;
    }
        int result = number % 10;
        return result;
}

// int randNumber= new Random().Next(0,1000000);
Console.WriteLine("Введите число не меньше трех знаков: ");
int randNumber = Convert.ToInt32(Console.ReadLine());
 while (randNumber <100)   
    {
    Console.WriteLine("Введено некорректное число");
    Console.WriteLine("Введите корректное число: ");
    randNumber = Convert.ToInt32(Console.ReadLine());
    }


    int newNumber = cutThirdDigit(randNumber);

        
Console.WriteLine($"Введенное число {randNumber} и третья цифра {newNumber}");



// Task 3. Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.


