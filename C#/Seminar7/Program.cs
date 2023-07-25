// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
int[,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue)
{
   int[,] array = new int[rows, columns];

   for (int i = 0; i < rows; i++)
   {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
   }        
        return array;
}         

void PrintArray (int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine ();
    }
}

Console.WriteLine ("Input a number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Input a number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Input a number of minValue: ");
int minValue = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Input a number of maxValue: ");
int maxValue = Convert.ToInt32 (Console.ReadLine());
 
int[,] myArray = CreateRandom2dArray  (rows, columns, minValue, maxValue);
PrintArray(myArray);

*/

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j.
// Выведите полученный массив на экран.
/*
int[,] CreateArray (int rows, int columns)
{
   int[,] array = new int[rows, columns];

   for (int i = 0; i < rows; i++)
   {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = i+j;
        }                              
   }        
        return array;
}  

void PrintArray (int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine ();
    }
}

Console.WriteLine ("Input a number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Input a number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine ("Input a number of minValue: ");
// int minValue = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine ("Input a number of maxValue: ");
// int maxValue = Convert.ToInt32 (Console.ReadLine());
 
int[,] myArray = CreateArray  (rows, columns);
PrintArray(myArray);
*/

                                                                                   
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
int[,] CreateNewArray (int rows, int columns, int minValue, int maxValue)
{
   int[,] array = new int[rows, columns];

   for (int i = 0; i < rows; i++)
   {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
   }        
        return array;

}         
    void QuadIndex (int[,] array)
    {
        for (int i  = 0; i < array.GetLength(0); i = i +2)
        {
            for (int j = 0; j < array.GetLength(1); j = j + 2)
            {
                array[i,j] *= array[i,j];   
            }
        }
        // Console.WriteLine(array[int,j])

         
    }

void PrintArray (int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine ();
    }
}

Console.WriteLine ("Input a number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Input a number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Input a number of minValue: ");
int minValue = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Input a number of maxValue: ");
int maxValue = Convert.ToInt32 (Console.ReadLine());
 
int[,] myArray = CreateNewArray  (rows, columns, minValue, maxValue);
PrintArray(myArray);
Console.WriteLine ("");
QuadIndex(myArray);
PrintArray(myArray);
Console.WriteLine();
*/


// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] Create2Array (int rows, int columns, int minValue, int maxValue)
{
   int[,] array = new int[rows, columns];

   for (int i = 0; i < rows; i++)
   {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
   }        
        return array;

}     

void PrintArray (int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine ();
    }
}

int  Sum (int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {
        sum += array[i,i];
    }
    return sum;
}

Console.WriteLine ("Input a number of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Input a number of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Input a number of minValue: ");
int minValue = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Input a number of maxValue: ");
int maxValue = Convert.ToInt32 (Console.ReadLine());
 
int[,] myArray = Create2Array  (rows, columns, minValue, maxValue);
PrintArray(myArray);
Console.WriteLine ();
int result = Sum(myArray);
Console.WriteLine (result);