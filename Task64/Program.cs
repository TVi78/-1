// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int InputNumber(string msg) 
// { 
//     System.Console.Write(msg); 
//     return Convert.ToInt32(Console.ReadLine()); 
// } 

// void RoadToN(int number, int i) 
// { 
//     if (i > number) { 
//         return; 
//         } 
//     RoadToN(number,i + 1); 
//     Console.Write($"{i} "); 
// } 

// int N = InputNumber("Введите число: "); 
// int i=1;
// RoadToN(N, i);

int InputNumber(string msg) 
{ 
    System.Console.Write(msg); 
    return Convert.ToInt32(Console.ReadLine()); 
} 

void RoadToN(int number) 
{ 
    if (number == 0) { 
        return; 
        } 
    System.Console.Write($"{number} "); 
    RoadToN(number - 1); 
} 

int N = InputNumber("Введите число: "); 
RoadToN(N);