// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// N = 5 -> "1, 2, 3, 4, 5" 
// N = 6 -> "1, 2, 3, 4, 5, 6" 

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
    RoadToN(number - 1); 
    System.Console.Write($"{number} "); 
} 

int N = InputNumber("Введите число: "); 
RoadToN(N);