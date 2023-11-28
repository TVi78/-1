// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. 
// 453 -> 12 
// 45 -> 9 

int InputNumber(string msg) 
    { 
        System.Console.Write(msg); 
        return Convert.ToInt32(Console.ReadLine()); 
    } 
    
    int SumDigital(int number)
    { 
        if (number == 0) 
        { 
            return 0; 
        } 
        return number % 10 + SumDigital(number / 10);
    } 
    
    int N = InputNumber("Введите число: "); 
    System.Console.WriteLine(SumDigital(N));