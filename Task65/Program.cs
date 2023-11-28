// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 6, 7, 8" 

int vvod(string msg) 
    { 
    System.Console.Write(msg); 
    return Convert.ToInt32(System.Console.ReadLine()); 
    } 
    
void recursion (int n,int m) 
    { 
    if (n==m-1) { 
        return; 
        } 
    
    recursion (n-1, m); 
    System.Console.Write(n); 
    } 
    
    int m = vvod("Введите число начала промежутка: "); 
    int n = vvod("Введите число конца промежутка: "); 
    recursion (n,m);