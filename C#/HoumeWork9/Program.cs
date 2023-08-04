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
/*
int SumNaturalDigit (int m, int n)
{
    if (m == n) return m;
    if (m < n)  return  m + SumNaturalDigit(m + 1, n);
    else return n + SumNaturalDigit(n + 1, m);         
      
}

Console.WriteLine (SumNaturalDigit(4,3));
*/

// Task 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman (int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.WriteLine(Akkerman(2,3));
