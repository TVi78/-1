﻿// Реализуйте класс Answer, который содержит следующие статические методы:
// SumOfRow(int[,] matrix, int row): Метод для вычисления суммы элементов в заданной строке row матрицы matrix. 
// Метод принимает двумерный массив целых чисел matrix и номер строки row, а возвращает целое число - сумму элементов в данной строке.
// MinimumSumRow(int[,] matrix): Метод для определения строки с наименьшей суммой элементов. Метод принимает двумерный массив целых 
// чисел matrix и возвращает массив из двух элементов: номер строки с наименьшей суммой (нумерация начинается с 0) и саму сумму.

using System;

public class Answer
{
    public static int SumOfRow(int[,] matrix, int row)
    {
// Введите свое решение ниже
    int sum=0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum+=matrix[row,j];
        }
    return sum;
    }

    public static int[] MinimumSumRow(int[,] matrix)
    {
// Введите свое решение ниже
    int min=0;
    int sum;
    int[] array=new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
     {
        sum=0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum+=matrix[i, j];
        }
        if(i==0){
            array[0]=i;
            array[1]=sum;
            min=sum;
        } 
        if (sum<min){
            array[0]=i;
            array[1]=sum;
            min=sum;
        } 
     }
    return array;
    }

 // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
          // Если аргументы не переданы, используем матрицу по умолчанию
            
            matrix = new int[,]
            {
                {5, 2, 9},
                {8, 1, 4},
                {1, 7, 3}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }

        int[] minSumRow = MinimumSumRow(matrix);

        Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");

        int rowToSum = 1; 
        int sum = SumOfRow(matrix, rowToSum);
        Console.WriteLine($"Сумма элементов в строке {rowToSum + 1}: {sum}");
    }
}