// Task 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateDoubleArray (int rows, int columns)
{
   double[,] array = new double[rows, columns];

    Random random = new Random();
   
   for (int i = 0; i < rows; i++)
   {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = random.NextDouble() * 10 ;
            array[i,j] = Math.Round(array[i,j], 2);

        }
   }        
    return array;
}         

void PrintArray (double[,] array)

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

double[,] myArray = CreateDoubleArray(rows, columns);
PrintArray(myArray);