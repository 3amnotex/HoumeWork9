// // Example 1. Напишите программу, которая на вход
// // принимает два числа и выдаёт большее число.

Console.WriteLine("Input num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
     Console.WriteLine("max = " + num1);
else Console.WriteLine("max = " + num2);


// // Example 2. Напишите программу, которая принимает на вход
// // три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Input num3: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input num4: ");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input num5: ");
int num5 = Convert.ToInt32(Console.ReadLine());
if (num3 > num4)
if (num3 > num5)
    Console.WriteLine("max = " + num3);
if (num4 > num3)
if (num4 > num5)
    Console.WriteLine("max = " + num4);
if (num5 > num3)
if (num5 > num4)
    Console.WriteLine("max = " + num5);


// // Example 3. Напишите программу, которая на вход 
// // принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
Console.WriteLine("Number " + num + " it is even");
// else Console.WriteLine("Number " + num + " it is an even");


// Example 4. Напишите программу, которая на вход 
// принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
for(int count = 1; count <= number; count++)
 {
if (count % 2 == 0)
 Console.Write(count + " ");
}