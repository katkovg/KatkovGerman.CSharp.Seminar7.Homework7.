// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
/*
double [,] createArray2D (double [,] array2D, double minimal, double maximal)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
         for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D [i, j] = new Random().NextDouble() * (maximal - minimal) + minimal;
        }
    }
    return array2D;
}

void showArray2D (double [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
         for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write(array2D [i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Input a number of rows:");
int userNumberOfRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns:");
int userNumberOfColumns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a minimal real number:");
double minValue = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input a maximal real number:");
double maxValue = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

double [,] userArray2D = new double [userNumberOfRows, userNumberOfColumns];


createArray2D(userArray2D, minValue, maxValue);
showArray2D(userArray2D);
*/

// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int [,] createArray2D (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
         for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D [i, j] = new Random().Next(-99, 100);
        }
    }
    return array2D;
}

void showArray2D (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
         for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write(array2D [i, j] + " ");
        }
        Console.WriteLine();
    }
}

bool checkElementOfArray2D (int rowIndex, int columnIndex, int [,] array2D)
{
    for (i = 0; i < array2D.GetLength(0); i++)
    {
        for (j = 0; j < array2D.GetLength(1); j++)
        {
            if (i == rowIndex && j == columnIndex) { Console.WriteLine($"Yes, this element exists (row: {i}, column: {j}). Its value is {array2D [i, j]}."); return true; }
        }
    }
    Console.WriteLine($"This element doesnt't exist (row: {rowIndex}, column: {columnIndex}).");
    return false;
}

int randomRows = new Random().Next(1, 11);
int randomColumns = new Random().Next(1, 11);

int [,] userArray2D = new int [randomRows, randomColumns];

createArray2D(userArray2D);

Console.WriteLine("The random array was created. You can watch it below.\n");

showArray2D(userArray2D);

Console.WriteLine();

Console.WriteLine("Input a row-index from zero:");
int userRowIndex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a column-index from zero:");
int userColumnIndex = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

checkElementOfArray2D(userRowIndex, userColumnIndex, userArray2D);
*/

// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int [,] createRandomArray2D (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
         for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D [i, j] = new Random().Next(0, 100);
        }
    }
    return array2D;
}
void findArithmeticMeanOfColumn (int [,] array2D)
{
    int sumOfNumbersInColumn = 0;
    double arithmeticMeanOfColumn = 0;
    int quantityOfNumbersInColumn = 0;
    int columnNumber = 0;

    for (int j = 0; j < array2D.GetLength(1); j++)
        {
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                sumOfNumbersInColumn += array2D [i, columnNumber];
                quantityOfNumbersInColumn++;
            }
            arithmeticMeanOfColumn = Convert.ToDouble(sumOfNumbersInColumn) / Convert.ToDouble(quantityOfNumbersInColumn);
            Console.WriteLine($"The arithmetic mean of column {columnNumber} is {arithmeticMeanOfColumn}");
            columnNumber++;
            sumOfNumbersInColumn = 0;
            quantityOfNumbersInColumn = 0;
        }
}

void showArray2D (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
         for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write(array2D [i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Input a number of rows:");
int userNumberOfRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns:");
int userNumberOfColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Input a minimal number:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a maximal number:");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] userArray2D = new int [userNumberOfRows, userNumberOfColumns];

createRandomArray2D(userArray2D);
showArray2D(userArray2D);
Console.WriteLine();

findArithmeticMeanOfColumn(userArray2D);
*/