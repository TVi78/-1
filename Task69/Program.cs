//Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии. 
// A = 3; B = 5 -> 243 (3⁵) 
// A = 2; B = 3 -> 8 

int vvod(string msg) 
    {
     System.Console.Write(msg); 
     return Convert.ToInt32(System.Console.ReadLine()); 
     }

int recursion (int A,int B) {
    if (B==0) 
    { 
        return 1; 
    } 
    return A*recursion (A, B-1); 
} 

int A = vvod("Введите число: "); 
int B= vvod("Введите степень: "); 
Console.Write(recursion (A,B));