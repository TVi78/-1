﻿// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double[] cross(double b1, double k1, double b2, double k2){
    double x=(b2-b1)/(k1-k2);
    double y= k1*x+b1;
    double[] koord=new double[2]{x, y};
    return koord;
}

Console.WriteLine("Введите b1: ");
double b1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2=Convert.ToDouble(Console.ReadLine());

Console.Write($"{cross(b1, k1, b2, k2)[0]}, {cross(b1, k1, b2, k2)[1]}");