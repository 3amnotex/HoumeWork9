// Task 1. Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
 void NaturalNumbers (int num)
{
   Console.WriteLine(num + " ");  
   if (num > 1) NaturalNumbers(num - 1);
}

NaturalNumbers(8);
*/
// Task 2.  Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNaturalDigit (int m, int n)
{
    if (m == n) return m;
    if (m < n)  return  m + SumNaturalDigit(m + 1, n);
    else return n + SumNaturalDigit(n + 1, m);         
      
}

Console.WriteLine (SumNaturalDigit(4,3));