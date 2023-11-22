// Задача 53: Задайте двумерный массив. Напишите программу, которая меняет местами первую и последнюю строку массива.

int InputNumber(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrixWhithRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int m = InputNumber("Введите число m: ");
int n = InputNumber("Введите число n: ");

int[,] matrix = new int[m, n];

matrix = FillMatrixWhithRandom(matrix);
PrintMatrix(matrix);

int[,] CreateMatrix(int[,] array){
int temp = 0;
//int[] arraytemp = new int[m];
for (int i = 0; i < m; i++)
{
    temp = array[0,i];
    array[0,i]=array[m-1,i];
    array[m-1,i]=temp;
}
return array;
}

System.Console.WriteLine();
matrix = CreateMatrix(matrix);
PrintMatrix(matrix);

