// Task 1.Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*
class Program
{
    static void SortRowsDescending(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            int[] rowArray = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                rowArray[j] = matrix[i, j];
            }

            Array.Sort(rowArray, (x, y) => y.CompareTo(x));

            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rowArray[j];
            }
        }
    }

    static void Main()
    {
       
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of cols: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    
        int[,] matrix = new int[rows, cols];

        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 101);
            }
        }

        Console.WriteLine("Исходный массив:");
        PrintMatrix(matrix);

        SortRowsDescending(matrix);

        Console.WriteLine("Массив после упорядочивания каждой строки по убыванию:");
        PrintMatrix(matrix);
        Console.WriteLine();
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/

// Task 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
class Program
{
    static int[,] CreateMyArray(int rows, int columns, int minValue, int maxValue)
    {
        int[,] array = new int[rows, columns];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(minValue, maxValue + 1);
            }
        }

        return array;
    }

    static int[,] ProductArray(int[,] array, int[,] newarray)
    {
        int rows1 = array.GetLength(0);
        int columns1 = array.GetLength(1);
        int rows2 = newarray.GetLength(0);
        int columns2 = newarray.GetLength(1);

      
        int[,] result = new int[rows1, columns2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                int sum = 0;
                for (int k = 0; k < columns1; k++)
                {
                    sum += array[i, k] * newarray[k, j];
                }
                result[i, j] = sum;
            }
        }

        return result;
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите размерность первого массива:");
        Console.WriteLine("Input a number of rows:");
        int rows1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input a number of columns:");
        int columns1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input a number of minValue:");
        int minValue1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input a number of maxValue:");
        int maxValue1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        int[,] myOneArray = CreateMyArray(rows1, columns1, minValue1, maxValue1);
        PrintArray(myOneArray);
        Console.WriteLine();

        Console.WriteLine("Введите размерность второго массива:");
        Console.WriteLine("Input a number of rows:");
        int rows2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input a number of columns:");
        int columns2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input a number of minValue:");
        int minValue2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input a number of maxValue:");
        int maxValue2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        int[,] myTwoArray = CreateMyArray(rows2, columns2, minValue2, maxValue2);
        PrintArray(myTwoArray);
        Console.WriteLine();

        int[,] product = ProductArray(myOneArray, myTwoArray);
        Console.WriteLine("Результат умножения матриц: ");
        Console.WriteLine();
        PrintArray(product);
        Console.WriteLine();
                  
    }
}

*/

// Task 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*

class Program
{
    static int[,] CreateMyArray(int rows, int columns, int minValue, int maxValue)
    {
        int[,] array = new int[rows, columns];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(minValue, maxValue + 1);
            }
        }

        return array;
    }

    static int[,] ProductArray(int[,] array, int[,] newarray)
    {
        int rows1 = array.GetLength(0);
        int columns1 = array.GetLength(1);
        int rows2 = newarray.GetLength(0);
        int columns2 = newarray.GetLength(1);

        if (columns1 != rows2)
        {
            throw new ArgumentException("Matrix dimensions do not match for multiplication.");
        }

        int[,] result = new int[rows1, columns2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                int sum = 0;
                for (int k = 0; k < columns1; k++)
                {
                    sum += array[i, k] * newarray[k, j];
                }
                result[i, j] = sum;
            }
        }

        return result;
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите размерность первого массива:");
        Console.WriteLine("Input a number of rows:");
        int rows1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input a number of columns:");
        int columns1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input a number of minValue:");
        int minValue1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input a number of maxValue:");
        int maxValue1 = Convert.ToInt32(Console.ReadLine());

        int[,] myOneArray = CreateMyArray(rows1, columns1, minValue1, maxValue1);
        PrintArray(myOneArray);
        Console.WriteLine();

        Console.WriteLine("Введите размерность второго массива:");
        Console.WriteLine("Input a number of rows:");
        int rows2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input a number of columns:");
        int columns2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input a number of minValue:");
        int minValue2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input a number of maxValue:");
        int maxValue2 = Convert.ToInt32(Console.ReadLine());

        int[,] myTwoArray = CreateMyArray(rows2, columns2, minValue2, maxValue2);
        PrintArray(myTwoArray);

        try
        {
            int[,] product = ProductArray(myOneArray, myTwoArray);
            Console.WriteLine("Result of matrix multiplication:");
            PrintArray(product);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
*/

// Task 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.



int[,,]  CreateMyArray(int rows, int columns, int depth)
{
   int[,,] array = new int[2, 2, 2];

   for (int i = 0; i < rows; i++)
   {
        for (int j = 0; j < columns; j++)
        {
            for(int k = 0; k < depth; k++)
            {
            array[i,j,k] = new Random().Next(10,100);
            }
        }
   }        
        return array;

}     


void PrintArray (int[,,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write (array[i,j,k] +" "+  (i, j, k) +" ");
            }
        }
        Console.WriteLine ();
    }
}


int[,,] myArray = CreateMyArray  (2,2,2);
PrintArray(myArray);





// Task 5. Напишите программу, которая заполнит спирально массив 4 на 4.

/*
class Programm
{
static void Main()
    {
        int[,] spiralArray = new int[4, 4];

        int num = 1;
        int size = 4;
        int row = 0;
        int col = -1;
        int increment = 1;

        while (size > 0)
        {
            for (int i = 0; i < size; i++)
            {
                col += increment;
                spiralArray[row, col] = num++;
            }

            size--;

            for (int i = 0; i < size; i++)
            {
                row += increment;
                spiralArray[row, col] = num++;
            }

            increment *= -1;
        }

        // Printing the spiral array
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(spiralArray[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
*/