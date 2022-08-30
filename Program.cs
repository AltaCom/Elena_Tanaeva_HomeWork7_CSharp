/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

double[,] CreateDouble2DArray(int m, int n, int minValue, int maxValue)
{
double[,] newArray = new double [m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
        newArray[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
}
    return newArray;
}
void ShowDouble2DArray (double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Math.Round (array[i, j], 1);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();

}
   Console.WriteLine();
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input minValue: ");
int min = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input maxValue: ");
int max = Convert.ToInt32(Console.ReadLine()); 

double[,] userArray = CreateDouble2DArray(m, n, min, max);
ShowDouble2DArray (userArray);



/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет


int[,] CreatNewArray (int rows, int columns, int minValue, int maxValue)
{
int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        newArray[i,j] = new Random().Next(minValue, maxValue + 1);

    }
    return newArray;
}

void Show2dArray (int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();

}
   Console.WriteLine();
}

bool FindElements (int[,] array)
{
    Console.Write("Input index i: ");
    int i = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Input index j: ");
    int j = Convert.ToInt32(Console.ReadLine()); 
    
    if (i >= 0 && i < array.GetLength(0) && j > 0 && j < array.GetLength(1)) 
    {
        Console.Write($"The element A ({i}, {j}) is {array[i, j]}");
        Console.WriteLine();
        return true;
    }
    else 
    {
        Console.Write("There is no such an element!");
        Console.WriteLine();
        return false;
    }
}
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input minValue: ");
int min = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input maxValue: ");
int max = Convert.ToInt32(Console.ReadLine()); 

int[,] userArray = CreatNewArray(m, n, min, max);
Show2dArray (userArray);
bool userElement = FindElements(userArray);
*/



/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateArray(int rows, int columns, int minValue, int maxValue)
{
int[,] newArray = new int[rows, columns]; 
    for (int i = 0; i < rows; i++)
    {
    for (int j = 0; j < columns; j++)
        newArray[i, j] = new Random().Next(minValue, maxValue+1);
     }

return newArray;
}

void Show2DArray (int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();

}
   Console.WriteLine();
}

void Average (int[,] array)
{     
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
            
        }
        double average = sum / array.GetLength(0);
        Console.Write(average + " ");
    }
Console.WriteLine();
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input minValue: ");
int min = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input maxValue: ");
int max = Convert.ToInt32(Console.ReadLine()); 

int[,] userArray = CreateArray(m, n, min, max);
Show2DArray (userArray);
Average(userArray);
            
*/

