// // Задача 47. Задайте двумерный массив размером m×n, заполненный 
// //случайными вещественными числами.
// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9

// double [,] Fill2dArray(int m, int n)
// {
//     double[,] array = new double[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//         array[i,j] = Math.Round((new Random().NextDouble())*
//         (new Random().Next(-100, 101)), 2);
//         }
//     }
//     return array;
// }

// void Print2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//     Console.WriteLine();
//     }
// }

// Console.Write("Enter number of rows: ");
// int rows = Convert.ToInt16(Console.ReadLine());
// Console.Write("Enter number of columns: ");
// int cols = Convert.ToInt16(Console.ReadLine());
// if(cols<1 || rows<1) Console.WriteLine
// ("Numbers of rows and columns must be greater than 0");
// else{

//   Print2dArray(Fill2dArray(rows, cols));  
// }



//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// int [,] Fill2dArray(int m, int n, int min, int max)
// {
//     int[,] array = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//         array[i,j] =new Random().Next(min, max+1);
//         }
//     }
//     return array;
// }

// void Print2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//     Console.WriteLine();
//     }
// }


// int rows  = 4;
// int cols  = 5;
// int max = 9;
// int min = 0;

// Console.Write("Enter row index: ");
// int row = Convert.ToInt16(Console.ReadLine());
// Console.Write("Enter column index: ");
// int col = Convert.ToInt16(Console.ReadLine());
// if(row>rows || col>cols) Console.WriteLine("There is no element with these indexes");
// else
// {
//     int[,] array = Fill2dArray(rows, cols, min, max);
//     Print2dArray(array);
//     Console.WriteLine($"Element indexed [{row},{col}] = {array[row, col]}");
// }



// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


double [,] Fill2dArray(int m, int n, int min, int max)
{
    double[,] array = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        array[i,j] =new Random().Next(min, max+1);
        }
    }
    return array;
}

void Print2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();
    }
}

double[] RowAverage(double[,] array)
{
    double[] averageRowArray = new double[array.GetLength(0)];
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            averageRowArray[i] = Math.Round(averageRowArray[i] + array[i,j]
                                /array.GetLength(1), 5);
        }
    }
    return averageRowArray;
}
 
 
 double[] ColumnAverage(double[,] array)
{
    double[] averageColArray = new double[array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            averageColArray[j] = Math.Round(averageColArray[j] + array[i,j]
                                /array.GetLength(0), 5);
        }
    }
    return averageColArray;
}
 
 
 
 void PrintArray(double[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }


Console.Write("Enter number of rows: ");
int rows = Convert.ToInt16(Console.ReadLine());
Console.Write("Enter number of columns: ");
int cols = Convert.ToInt16(Console.ReadLine());
if(cols<1 || rows<1) Console.WriteLine
("Numbers of rows and columns must be greater than 0");
else
{
    double[,] array = Fill2dArray(rows, cols, 0, 9);
    Print2dArray(array);  
    Console.WriteLine();
    Console.WriteLine("Rows average");
    PrintArray(RowAverage(array));
    Console.WriteLine("Columns average");
    PrintArray(ColumnAverage(array));
}