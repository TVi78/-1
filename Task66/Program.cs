// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int vvod(string msg) 
    { 
    System.Console.Write(msg); 
    return Convert.ToInt32(System.Console.ReadLine()); 
    } 
    
int recursion (int n,int m) 
    { 
    if (n==m-1) { 
        return 0; 
        } 
    n+=recursion(n-1, m); 
    return n;
    } 
    
    int m = vvod("Введите число начала промежутка: "); 
    int n = vvod("Введите число конца промежутка: "); 
    System.Console.Write(recursion (n,m)); 