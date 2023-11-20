// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// double[] cross(double b1, double k1, double b2, double k2){
//     double x=(b2-b1)/(k1-k2);
//     double y= k1*x+b1;
//     double[] koord=new double[2]{x, y};
//     return koord;
// }

// Console.WriteLine("Введите b1: ");
// double b1=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите k1: ");
// double k1=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите b2: ");
// double b2=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите k2: ");
// double k2=Convert.ToDouble(Console.ReadLine());

// Console.Write($"{cross(b1, k1, b2, k2)[0]}, {cross(b1, k1, b2, k2)[1]}");


decimal vvod(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToDecimal(System.Console.ReadLine());
}

decimal k1 = vvod("Введите коэффициент k1 для уравнения вида y=kx+b");
decimal b1 = vvod("Введите коэффициент b1 для уравнения вида y=kx+b");

decimal k2 = vvod("Введите коэффициент k2 для другого уравнения вида y=kx+b");
decimal b2 = vvod("Введите коэффициент b2 для другого уравнения вида y=kx+b");

if (k1 == k2)
{
    if (b1 == b2)
    {
        System.Console.WriteLine("Линии вида y=kx+b при введенных коэффициентах лежат друг на друге");
    }
    else
    {
        System.Console.WriteLine("Линии вида y=kx+b при введенных коэффициентах параллельны друг другу");
    }
}
else
{
    decimal x = (b2 - b1) / (k1 - k2);
    decimal y = k1 * x + b1;

    System.Console.WriteLine($"Линии для уравнения вида y=kx+b пересекаются в точке с координатами ({x},{y})");
}