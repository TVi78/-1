// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со 
// сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// int storona (string msg)
// {

// System.Console.WriteLine(msg);
// return Convert.ToInt32(System.Console.ReadLine());
// }

// int a=storona("Введите натуральное число: ");
// int b=storona("Введите натуральное число: ");
// int c=storona("Введите натуральное число: ");

// if ((a<b+c)&&(b<a+c)&&(c<b+a))
// {System.Console.WriteLine("Из отрезков заданной длины можно сделать треугольник");}
// else 
// {System.Console.WriteLine("Треугольник не получится");}

int side(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int a = side("Введите сторону треугольника");
int b = side("Введите сторону треугольника");
int c = side("Введите сторону треугольника");

bool Validation()
{
    if ((a < b + c) && (b < a + c) && (c < b + a))
    {
        return true;
    }
    else
    {
        return false;
    }
}

Validation();

if (true){
    System.Console.WriteLine("True");
}
else{
    System.Console.WriteLine("False");
}